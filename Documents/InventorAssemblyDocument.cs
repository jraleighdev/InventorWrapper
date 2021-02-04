using Inventor;
using InventorWrapper.Components;
using InventorWrapper.Constraints;
using InventorWrapper.Parameters;
using InventorWrapper.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventorWrapper.BOM;

namespace InventorWrapper.Documents
{
    public class InventorAssemblyDocument : InventorDocument 
    {
       
        private List<InventorDocument> _referencedDocuments;

        private InventorPatterns _inventorPatterns;

        private InventorComponents _components;

        private InventorConstraints _constraints;

        private InventorBom _bom;

        public AssemblyDocument _adoc;

        public AssemblyComponentDefinition _adef;

        public InventorAssemblyDocument(Document document) : base(document)
        {
            _adoc = document as AssemblyDocument;

            _adef = _adoc.ComponentDefinition;

            var f = _adef.Features;
        }

        public List<InventorDocument> ReferencedDocuments
        {
            get
            {
                if (_referencedDocuments == null)
                {
                    _referencedDocuments = new List<InventorDocument>();

                    foreach (Document doc in _adoc.AllReferencedDocuments)
                    {
                        _referencedDocuments.Add(new InventorDocument(doc));
                    }
                }

                return _referencedDocuments;
            }            
        }

        public InventorPatterns Patterns
        {
            get
            {
                if (_inventorPatterns == null)
                {
                    _inventorPatterns = new InventorPatterns(this);
                }

                return _inventorPatterns;
            }
        }

        public InventorComponents Components
        {
            get
            {
                if (_components == null)
                {
                    _components = new InventorComponents(this);
                }

                return _components;
            }
        }

        public InventorConstraints Constraints
        {
            get
            {
                if (_constraints == null)
                {
                    _constraints = new InventorConstraints(this);
                }

                return _constraints;
            }
        }

        public InventorDocument GetReferencedDocument(string name)
        {
            InventorDocument tempdoc = null;

            foreach (Document doc in _adoc.AllReferencedDocuments)
            {
                if (System.IO.Path.GetFileNameWithoutExtension(doc.FullFileName) == name)
                {
                    tempdoc = new InventorDocument(doc);

                    break;
                }
            }

            return tempdoc;
        }

        public InventorBom Bom
        {
            get
            {
                if (_bom == null)
                {
                    _bom = new InventorBom(this._adef.BOM);
                }

                return _bom;
            }
        }

        public override void Dispose()
        {
            if (_referencedDocuments != null)
            {
                foreach (var d in _referencedDocuments)
                {
                    d.Dispose();
                }
            }

            base.Dispose();
        }
    }
}
