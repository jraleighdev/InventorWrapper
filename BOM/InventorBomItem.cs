using System;
using System.Runtime.InteropServices;
using Inventor;
using InventorWrapper.Documents;

namespace InventorWrapper.BOM
{
    public class InventorBomItem : IDisposable
    {
        private BOMRow _row;

        private InventorDocument _document;

        public InventorBomItem(BOMRow row)
        {
            _row = row;
        }

        public InventorDocument Document
        {
            get
            {
                if (_document == null)
                {
                    _document = new InventorDocument(_row.ComponentDefinitions[1].Document as Document);
                }

                return _document;
            }
        }

        public int Qty => _row.ItemQuantity;

        public void Dispose()
        {
            if (_row != null)
            {
                Marshal.ReleaseComObject(_row);
                _row = null;
            }
            
        }
    }
}