using Inventor;
using InventorWrapper.CaptureDto;
using InventorWrapper.CaptureDto.Enums;
using InventorWrapper.Components;
using InventorWrapper.Features;
using InventorWrapper.IProps;
using InventorWrapper.Parameters;
using InventorWrapper.Patterns;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using InventorWrapper.Representation;

namespace InventorWrapper.Documents
{
    /// <summary>
    /// Base class of inventor documents
    /// All sub documents inherit from this class
    /// </summary>
    public class InventorDocument : IDisposable
    {
        /// <summary>
        /// Reference to the inventor document interop
        /// </summary>
        public Document _document;

        private InventorParameters _parameters;

        private InventorRepresentationManager _representationManager;

        private InventorProperties _properties;

        private List<InventorFeature> _features;

        /// <summary>
        /// Name of document without the file extension
        /// </summary>
        public string Name => System.IO.Path.GetFileNameWithoutExtension(_document.FullFileName);

        /// <summary>
        /// Full file name of the document
        /// </summary>
        public string FileName => _document.FullFileName;

        /// <summary>
        /// Unique id created for tracking the document
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// If the document is an assembly document
        /// </summary>
        public bool IsAssemblyDoc => _document.DocumentType == DocumentTypeEnum.kAssemblyDocumentObject;

        /// <summary>
        /// If the document is a part document
        /// </summary>
        public bool IsPartDoc => _document.DocumentType == DocumentTypeEnum.kPartDocumentObject;

        /// <summary>
        /// If the document is a drawing document
        /// </summary>
        public bool IsDrawingDoc => _document.DocumentType == DocumentTypeEnum.kDrawingDocumentObject;

        /// <summary>                   
        /// Parameters for the documents
        /// </summary>                  
        public InventorParameters Parameters
        {
            get
            {
                if (_parameters == null)
                {
                    if (IsAssemblyDoc)
                    {
                        AssemblyDocument adoc = _document as AssemblyDocument;

                        _parameters = new InventorParameters(adoc.ComponentDefinition.Parameters);
                    }
                    else if (IsPartDoc)
                    {
                        PartDocument pDoc = _document as PartDocument;

                        _parameters = new InventorParameters(pDoc.ComponentDefinition.Parameters);
                    }
                }

                return _parameters;
            }
        }

        /// <summary>                                                                             
        /// Representations manager for the document manges visible parts and level of detail     
        /// </summary>                                                                            
        public InventorRepresentationManager RepresentationManager
        {
            get
            {
                if (_representationManager == null)
                {
                    if (IsAssemblyDoc)
                    {
                        var adoc = _document as AssemblyDocument;

                        _representationManager =
                            new InventorRepresentationManager(adoc.ComponentDefinition.RepresentationsManager);
                    }
                    else if (IsPartDoc)
                    {
                        var pDoc = _document as PartDocument;

                        _representationManager =
                            new InventorRepresentationManager(pDoc.ComponentDefinition.RepresentationsManager);
                    }
                }

                return _representationManager;
            }
        }

        /// <summary>                                                                             
        /// Document properties allows access to general document properties and custom properties
        /// </summary>                                                                            
        public InventorProperties Properties
        {
            get
            {
                if (_properties == null)
                {
                    _properties = new InventorProperties(_document.PropertySets);
                }

                return _properties;
            }
        }

        /// <summary>                                    
        /// Features of the document edges, faces, etc...
        /// </summary>                                   
        public List<InventorFeature> Features
        {
            get
            {
                if (_features == null)
                {
                    _features = new List<InventorFeature>();

                    if (IsPartDoc)
                    {
                        PartDocument pdoc = _document as PartDocument;

                        foreach (PartFeature p in pdoc.ComponentDefinition.Features)
                        {
                            _features.Add(new InventorFeature(p));
                        }
                    }
                    else if (IsAssemblyDoc)
                    {
                        AssemblyDocument adoc = _document as AssemblyDocument;

                        foreach (PartFeature p in adoc.ComponentDefinition.Features)
                        {
                            _features.Add(new InventorFeature(p));
                        }
                    }
                }

                return _features;
            }
        }

        /// <summary>
        /// Stores the interop reference and initializes the id
        /// </summary>
        /// <param name="doc"></param>
        public InventorDocument(Document doc)
        {
            _document = doc;
            Id = Guid.NewGuid();
        }

        /// <summary>
        /// Gets the assembly document object from the document
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception">If the document is not an assembly document will throw an error</exception>
        public InventorAssemblyDocument GetAssemblyDocument(bool allChildren = false)
        {
            if (!IsAssemblyDoc) throw new Exception($"Document {Name} is not an assembly document");

            return new InventorAssemblyDocument(_document, allChildren);
        }

        /// <summary>
        /// Gets the part document object from the document
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception">If the document is not a part document will throw an error</exception>
        public InventorPartDocument GetPartDocument()
        {
            if (!IsPartDoc) throw new Exception($"Document {Name} is not a part document");

            return new InventorPartDocument(_document);
        }

        /// <summary>                                                                                           
        /// Gets the drawing document object from the document                                                     
        /// </summary>                                                                                          
        /// <returns></returns>                                                                                 
        /// <exception cref="Exception">If the document is not a drawing document will throw an error</exception>  
        public InventorDrawingDocument GetDrawingDocument()
        {
            if (!IsDrawingDoc) throw new Exception($"Document {Name} is not a drawing document");

            return new InventorDrawingDocument(_document);
        }

        /// <summary>
        /// Saves the document
        /// </summary>
        public void Save() => _document.Save2(true);

        /// <summary>
        /// Saves a copy of the document
        /// </summary>
        /// <param name="name"></param>
        public void SaveAs(string name, bool saveCopyAs = false)
        {
            _document.SaveAs(name, saveCopyAs);
        }

        /// <summary>
        /// Closes the document
        /// </summary>
        public void Close() => _document.Close();

        /// <summary>
        /// Updates the document from internal updates
        /// </summary>
        public void Update() => _document.Update2(true);

        /// <summary>
        /// Sets the status of a feature in the document
        /// </summary>
        /// <param name="name">Name of the feature</param>
        /// <param name="status">True of False if the feature should be active</param>
        /// <returns></returns>
        public bool SetFeatureStatus(string name, bool status)
        {
            var value = false;

            if (_document.DocumentType == DocumentTypeEnum.kPartDocumentObject)
            {
                PartDocument pdoc = _document as PartDocument;

                foreach (PartFeature p in pdoc.ComponentDefinition.Features)
                {
                    if (p.Name == name)
                    {
                        p.Suppressed = status;
                        value = true;
                        break;
                    }
                }
            }
            else if (_document.DocumentType == DocumentTypeEnum.kAssemblyDocumentObject)
            {
                AssemblyDocument adoc = _document as AssemblyDocument;

                foreach (PartFeature f in adoc.ComponentDefinition.Features)
                {
                    if (f.Name == name)
                    {
                        f.Suppressed = status;
                        value = true;
                        break;
                    }
                }
            }

            return value;
        }

        /// <summary>
        /// Selects the document from the active model
        /// </summary>
        /// <param name="select"></param>
        public void Select(object select)
        {
            try
            {
                _document.SelectSet.Select(select);
            }
            catch (Exception ex)
            {
                throw new Exception($"Could not select object {ex.Message}");
            }
        }

        /// <summary>
        /// Selects a feature based on data in the dto
        /// </summary>
        /// <param name="featureCapture">Data from the feature used to select the feature in the active document</param>
        public void Select(FeatureCaptureDto featureCapture)
        {
            switch (featureCapture.Type)
            {
                case FeatureCaptureType.Component:
                    if (featureCapture.FeatureSource is InventorComponent comp)
                    {
                        Select(comp._component);
                    }
                    break;
                case FeatureCaptureType.Feature:
                    if (featureCapture.FeatureSource is InventorFeature feature)
                    {
                        Select(feature._feature);
                    }
                    break;
                case FeatureCaptureType.Pattern:
                    if (featureCapture.FeatureSource is InventorPattern pattern)
                    {
                        Select(pattern._pattern);
                    }
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Returns the select item in the active document
        /// </summary>
        /// <returns></returns>
        public object SelectedItem()
        {
            if (_document.SelectSet.Count != 1) return null;

            return _document.SelectSet[1];
        }

        /// <summary>
        /// Returns all the selected items
        /// </summary>
        /// <returns></returns>
        public List<object> SelectedItems()
        {
            if (_document.SelectSet.Count == 0) return null;

            var tempList = new List<object>();

            foreach (var s in _document.SelectSet)
            {
                tempList.Add(s);
            }

            return tempList;
        }

        /// <summary>
        /// Clear the selections
        /// </summary>
        public void ClearSelection()
        {
            _document.SelectSet.Clear();
        }

        public void Activate()
        {
            _document.Activate();
        }

        public virtual void Dispose()
        {
            if (_document != null)
            {
                Marshal.ReleaseComObject(_document);
            }
        }
    }
}
