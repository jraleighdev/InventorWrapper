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
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Documents
{
    public class InventorDocument : IDisposable
    {
        public Document _document;

        private InventorParameters _parameters;

        private InventorProperties _properties;

        private List<InventorFeature> _features;

        public string Name => System.IO.Path.GetFileNameWithoutExtension(_document.FullFileName);

        public string FileName => _document.FullFileName;

        public string Id => Guid.NewGuid().ToString();

        public bool IsAssemblyDoc => _document.DocumentType == DocumentTypeEnum.kAssemblyDocumentObject;

        public bool IsPartDoc => _document.DocumentType == DocumentTypeEnum.kPartDocumentObject;

        public bool IsDrawingDoc => _document.DocumentType == DocumentTypeEnum.kDrawingDocumentObject;

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

        public InventorDocument(Document doc)
        {
            _document = doc;
        }

        public InventorAssemblyDocument GetAssemblyDocument()
        {
            if (!IsAssemblyDoc) throw new Exception($"Document {Name} is not an assembly document");

            return new InventorAssemblyDocument(_document);
        }

        public InventorPartDocument GetPartDocument()
        {
            if (!IsPartDoc) throw new Exception($"Document {Name} is not a part document");

            return new InventorPartDocument(_document);
        }

        public InventorDrawingDocument GetDrawingDocument()
        {
            if (!IsDrawingDoc) throw new Exception($"Document {Name} is not a drawing document");

            return new InventorDrawingDocument(_document);
        }

        public void Save() => _document.Save2(true);

        public void SaveAs(string name)
        {
            _document.SaveAs(name, true);
        }

        public void Close() => _document.Close();

        public void Update() => _document.Update2(true);

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

        public void Select(object select)
        {
            try
            {
                _document.SelectSet.Select(select);
            }
            catch (Exception ex)
            {
                Debugger.Break();
            }
        }

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

        public object SelectedItem()
        {
            if (_document.SelectSet.Count != 1) return null;

            return _document.SelectSet[1];
        }

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

        public void ClearSelection()
        {
            _document.SelectSet.Clear();
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
