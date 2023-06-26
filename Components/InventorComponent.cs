using Inventor;
using InventorWrapper.Documents;
using InventorWrapper.Features;
using InventorWrapper.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Components
{
    /// <summary>
    /// Inventor component reference represents a component in the model
    /// </summary>
    public class InventorComponent : IDisposable
    {
        /// <summary>
        /// Document reference of the component
        /// </summary>
        private InventorDocument _document;

        private List<InventorProxy> _proxies;

        private List<InventorComponent> _occurencePath;

        /// <summary>
        /// Default attribute set when adding name
        /// to a face through the inventor ui.
        /// </summary>
        public const string iLogicEntityNameSet = "iLogicEntityNameSet";

        /// <summary>
        /// Steps down in the component hierachy to this component
        /// </summary>
        private ComponentOccurrencesEnumerator _paths;

        /// <summary>
        /// Interop reference for the component
        /// </summary>
        public ComponentOccurrence _component;

        /// <summary>
        /// Name of the component
        /// </summary>
        public string Name => _component.Name;

        /// <summary>
        /// Gets and sets the visibility of the component
        /// </summary>
        public bool Visible
        {
            get => _component.Visible;
            set => _component.Visible = value;
        }

        /// <summary>
        /// Overide for to use a custom attribute set
        /// </summary>
        public string EntityNameOveride { get; set; }

        public string EntityNameSet => string.IsNullOrEmpty(EntityNameOveride) ? iLogicEntityNameSet : EntityNameOveride;
       
        /// <summary>
        /// Gets proxies for all the named features 
        /// in the component that belong to iLogicEntityNameSet by 
        /// Default to override set 
        /// </summary>
        /// <returns></returns>
        public List<InventorProxy> Proxies
        {
            get
            {
                if (_proxies == null)
                {
                    _proxies = GetProxies();
                }

                return _proxies;
            }
        }

        /// <summary>
        /// Level of detail of the component
        /// </summary>
        public string LevelOfDetail
        {
            get => _component.ActiveLevelOfDetailRepresentation;
            set
            {
                _component.SetLevelOfDetailRepresentation(value);
            }
        }

        /// <summary>
        /// Level of detail of the component
        /// </summary>
        public string DesignViewRep
        {
            get => _component.ActiveDesignViewRepresentation;
            set
            {
                _component.SetDesignViewRepresentation(value);
            }
        }

        /// <summary>
        /// Gets and sets the suppression status of the component
        /// </summary>
        public bool Suppressed
        {
            get => _component.Suppressed;

            set
            {
                if (value)
                {
                    if (!_component.Suppressed)
                    {
                        _component.Suppress();
                    }
                }
                else
                {
                    if (_component.Suppressed)
                    {
                        _component.Unsuppress();
                    }
                }
            }
        }

        /// <summary>
        /// If the component is a pattern element
        /// </summary>
        public bool IsPatternElement => _component.IsPatternElement;

        /// <summary>
        /// Inventor document reference
        /// </summary>
        public InventorDocument Document
        {
            get
            {
                if (_document == null && !Suppressed)
                {
                    var doc = _component.Definition.Document as Document;

                    if (doc != null)
                    {
                        _document = new InventorDocument(doc);
                    }
                }

                return _document;
            }
        }

        public List<InventorComponent> OccurencePath
        {
            get
            {
                if (_occurencePath == null)
                {
                    _occurencePath = new List<InventorComponent>();

                    foreach (ComponentOccurrence occ in _paths)
                    {
                        _occurencePath.Add(new InventorComponent(occ));
                    }
                }

                return _occurencePath;
            }
        }

        /// <summary>
        /// List of names of the component occurences
        /// </summary>
        public List<string> OccurenceList => OccurencePath.Select(x => x.Name).ToList();

        /// <summary>
        /// Command delimited string of the occurence liste
        /// </summary>
        public string PathList => string.Join(",", OccurenceList);

        public InventorComponent(ComponentOccurrence component)
        {
            _component = component;
            _paths = component.OccurrencePath;
        }

        public void Delete()
        {
            _component.Delete();
        }

        public void Dispose()
        {
            if (_component != null)
            {
                Marshal.ReleaseComObject(_component);
            }

            if (_paths != null)
            {
                Marshal.ReleaseComObject(_paths);
            }

            if (_occurencePath != null )
            {
                _occurencePath.ForEach(x => x.Dispose());
            }
        }

        private List<InventorProxy> GetProxies()
        {
            var tempList = new List<InventorProxy>();

            if (Suppressed) return tempList;

            if (Document.IsAssemblyDoc)
            {
                var adoc = _document.GetAssemblyDocument();

                foreach (var plane in adoc.WorkPlanes)
                {
                    object planeProxy;
                    _component.CreateGeometryProxy(plane._workPlane, out planeProxy);
                    WorkPlaneProxy workPlaneProxy = planeProxy as WorkPlaneProxy;
                    tempList.Add(new InventorProxy
                    (
                     planeProxy,
                     FeatureTypes.WorkPlane,
                     plane.Name,
                     ""
                    ));
                }

                foreach (var axis in adoc.WorkAxes)
                {
                    object axisProxy;
                    _component.CreateGeometryProxy(axis._axis, out axisProxy);
                    WorkAxisProxy workPlaneProxy = axisProxy as WorkAxisProxy;
                    tempList.Add(new InventorProxy
                    (
                     axisProxy,
                     FeatureTypes.WorkPlane,
                     axis.Name,
                     ""
                    ));
                }
            }
            else if (Document.IsPartDoc)
            {
                var pDoc = _document.GetPartDocument();

                foreach (var plane in pDoc.WorkPlanes)
                {
                    object workPlaneProxy;
                    _component.CreateGeometryProxy(plane._workPlane, out workPlaneProxy);
                    tempList.Add(new InventorProxy
                    (
                     workPlaneProxy,
                     FeatureTypes.WorkPlane,
                     plane.Name,
                     ""
                    ));
                }

                foreach (var axis in pDoc.WorkAxes)
                {
                    object axisProxy;
                    _component.CreateGeometryProxy(axis._axis, out axisProxy);
                    tempList.Add(new InventorProxy
                    (
                     axisProxy,
                     FeatureTypes.WorkPlane,
                     axis.Name,
                     ""
                    ));
                }

                foreach (SurfaceBody surface in pDoc._partDef.SurfaceBodies)
                {
                    foreach (Face face in surface.Faces)
                    {
                        if (face.AttributeSets.NameIsUsed[EntityNameSet])
                        {
                            AttributeSet attSet = face.AttributeSets[EntityNameSet];

                            Inventor.Attribute att = attSet[1];

                            object faceProxy;
                            _component.CreateGeometryProxy(face, out faceProxy);
                            tempList.Add(new InventorProxy(faceProxy, FeatureTypes.Face, att.Value.ToString(), att.Name));
                        }
                    }

                    foreach (Edge edge in surface.Edges)
                    {
                        if (edge.AttributeSets.NameIsUsed[EntityNameSet])
                        {
                            AttributeSet attSet = edge.AttributeSets[EntityNameSet];

                            Inventor.Attribute att = attSet[1];

                            object edgeProxy;
                            _component.CreateGeometryProxy(edge, out edgeProxy);
                            tempList.Add(new InventorProxy(edgeProxy, FeatureTypes.Face, att.Value.ToString(), att.Name));
                        }
                    }
                }
            }

            return tempList;
        }
    }
}
