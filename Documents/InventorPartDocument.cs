using Inventor;
using InventorWrapper.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Documents
{
    /// <summary>
    /// Part document for inventor
    /// </summary>
    public class InventorPartDocument : InventorDocument
    {
        private InventorWorkPlanes _inventorWorkPlanes;

        private InventorWorkAxes _inventorWorkAxes;

        /// <summary>
        /// Reference to the interop part document 
        /// </summary>
        public PartDocument _partDoc;

        /// <summary>
        /// Component definition for the part document
        /// </summary>
        public PartComponentDefinition _partDef;

        public InventorWorkPlanes WorkPlanes
        {
            get
            {
                if (_inventorWorkPlanes == null)
                {
                    _inventorWorkPlanes = new InventorWorkPlanes(_partDef);
                }

                return _inventorWorkPlanes;
            }
        }

        public InventorWorkAxes WorkAxes
        {
            get
            {
                if (_inventorWorkAxes == null)
                {
                    _inventorWorkAxes = new InventorWorkAxes(_partDef);
                }

                return _inventorWorkAxes;
            }
        }

        public InventorPartDocument(Document doc) : base(doc)
        {
            _partDoc = doc as PartDocument;
            _partDef = _partDoc.ComponentDefinition;
        }
    }
}
