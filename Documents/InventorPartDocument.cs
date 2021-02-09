using Inventor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Documents
{
    /// <summary>
    /// Part document for inventor
    /// </summary>
    public class InventorPartDocument : InventorDocument
    {
        /// <summary>
        /// Reference to the interop part document 
        /// </summary>
        public PartDocument _partDoc;

        /// <summary>
        /// Component definition for the part document
        /// </summary>
        public PartComponentDefinition _partDef;

        public InventorPartDocument(Document doc) : base(doc)
        {
            _partDoc = doc as PartDocument;
            _partDef = _partDoc.ComponentDefinition;
        }
    }
}
