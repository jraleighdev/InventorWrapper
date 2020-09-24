using Inventor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Documents
{
    public class InventorPartDocument : InventorDocument
    {
        public PartDocument _partDoc;

        public PartComponentDefinition _partDef;

        public InventorPartDocument(Document doc) : base(doc)
        {
            _partDoc = doc as PartDocument;
            _partDef = _partDoc.ComponentDefinition;
        }
    }
}
