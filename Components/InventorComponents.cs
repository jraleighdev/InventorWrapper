using Inventor;
using InventorWrapper.Components.Options;
using InventorWrapper.Documents;
using InventorWrapper.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Components
{
    /// <summary>
    /// Collection of inventor component
    /// </summary>
    public class InventorComponents : List<InventorComponent>, IDisposable
    {
        private InventorAssemblyDocument _adoc;

        /// <summary>
        /// Sets the reference to the assembly document and if recursion is true will grab all the child occurrences of sub assemblies
        /// </summary>
        /// <param name="adoc"></param>
        /// <param name="recurse"></param>
        public InventorComponents(InventorAssemblyDocument adoc, bool recurse = false)
        {
            _adoc = adoc;

            GetComponents(_adoc._adef.Occurrences, recurse);
        }

        /// <summary>
        /// Tries to set the level of detail of every component in the assembly
        /// </summary>
        /// <param name="levelOfDetail"></param>
        public void SetLevelOfDetailToAllComponents(string levelOfDetail)
        {
            foreach (var component in this) 
            { 
                if (component.Document.RepresentationManager.GetLevelDetails().Any(x => x.Equals(levelOfDetail)))
                {
                    component.LevelOfDetail = levelOfDetail;
                }
            }
        }

        /// <summary>
        /// Sets the status of component in the assembly by reference
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <exception cref="Exception"></exception>
        public void SetComponentStatus(string name, bool value)
        {
            try
            {
                ComponentOccurrence occ = _adoc._adef.Occurrences.ItemByName[name];

                if (value)
                {
                    occ.BOMStructure = BOMStructureEnum.kReferenceBOMStructure;
                    occ.Suppress();
                }
                else
                {
                    occ.Unsuppress();
                    occ.BOMStructure = BOMStructureEnum.kDefaultBOMStructure;
                }
            }
            catch 
            {
                throw new Exception("Could not find component " + name);
            }
        }

        /// <summary>
        /// Deletes the component by name
        /// </summary>
        /// <param name="name"></param>
        /// <exception cref="Exception"></exception>
        public void DeleteComponent(string name)
        {
            var componentToRemove = this.FirstOrDefault(x => x.Name == name);

            if (componentToRemove == null) throw new Exception($"Could not find component {name} in document {_adoc.Name}");

            componentToRemove.Delete();

            componentToRemove.Dispose();

            Remove(componentToRemove);

        }

        /// <summary>
        /// Deletes all components in the by document reference
        /// </summary>
        /// <param name="name"></param>
        public void DeleteComponents(string name)
        {
            foreach (ComponentOccurrence c in _adoc._adef.Occurrences)
            {
                var suppressed = false;

                if (c.Suppressed)
                {
                    suppressed = true;
                    c.Unsuppress();
                }

                if (System.IO.Path.GetFileNameWithoutExtension(((Document)c.Definition.Document).FullFileName) == name)
                {
                    if (c.IsPatternElement)
                    {
                        // TODO Look into supporting pattern elements
                        continue;
                    }
                    else
                    {
                        c.Delete();
                    }
                }
                else
                {
                    if (suppressed)
                    {
                        c.Suppress();
                    }
                }
            }
        }

        /// <summary>
        /// Gets the status of component in the assembly
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool GetComponentStatus(string name)
        {
            try
            {
                ComponentOccurrence occ = _adoc._adef.Occurrences.ItemByName[name];

                return occ.Suppressed;
            }
            catch
            {
                throw new Exception("Could not find component " + name);
            }
        }

        /// <summary>
        /// Gets all the components in the active assembly
        /// </summary>
        /// <param name="occurrences"></param>
        /// <param name="recurse"></param>
        public void GetComponents(ComponentOccurrences occurrences, bool recurse)
        {
            foreach (ComponentOccurrence c in occurrences)
            {
                Add(new InventorComponent(c));

                if (recurse)
                {
                    if (c.Definition.Type == ObjectTypeEnum.kAssemblyComponentDefinitionObject || c.Definition.Type == ObjectTypeEnum.kWeldmentComponentDefinitionObject)
                    {
                        var subOccurences = c.SubOccurrences as ComponentOccurrences;

                        GetComponents(subOccurences, recurse);
                    }
                }
            }
        }

        /// <summary>
        /// Place component in assembly
        /// </summary>
        /// <param name="fileName">Path to source file to place</param>
        /// <param name="options">Option include representaion and level of detail. Default options are provided in Default options class</param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public InventorComponent PlaceComponentWithOptions(string fileName, 
            List<InventorNameValueMapOptions> options,
            double x = 0, 
            double y = 0, 
            double z = 0
           )
        {
            TransientGeometry transientGeometry = InventorApplication.GetTransientGeometry();
            Matrix matrix = transientGeometry.CreateMatrix();
            NameValueMap objectNameMapOptions = InventorApplication.GetTransientObjects().CreateNameValueMap();
            foreach (var option in options)
            {
                objectNameMapOptions.Add(option.Name, option.Value);
            }

            matrix.SetTranslation(transientGeometry.CreateVector(x, y, z));
            var occurence = _adoc._adef.Occurrences.AddWithOptions(fileName, matrix, objectNameMapOptions);

            var component = new InventorComponent(occurence);

            Add(component);

            Marshal.ReleaseComObject(transientGeometry);
            Marshal.ReleaseComObject(matrix);
            Marshal.ReleaseComObject(objectNameMapOptions);

            return component;
        }

        /// <summary>
        /// Places a component in the active assembly
        /// </summary>
        /// <param name="fileName">Path to source file to place</param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        public InventorComponent PlaceComponent(string fileName,
            double x = 0,
            double y = 0,
            double z = 0
           )
        {
            TransientGeometry transientGeometry = InventorApplication.GetTransientGeometry();
            Matrix matrix = transientGeometry.CreateMatrix();

            matrix.SetTranslation(transientGeometry.CreateVector(x, y, z));
            var occurence = _adoc._adef.Occurrences.Add(fileName, matrix);

            var component = new InventorComponent(occurence);

            Add(component);

            Marshal.ReleaseComObject(transientGeometry);
            Marshal.ReleaseComObject(matrix);

            return component;
        }


        public void Dispose()
        {
            if (Count > 0)
            {
                foreach (var c in this)
                {
                    if (c != null)
                    {
                        c.Dispose();
                    }
                }
            }
        }
    }
}
