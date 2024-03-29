﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Inventor;
using InventorWrapper.Documents;

namespace InventorWrapper.BOM
{
    /// <summary>
    /// Single row of the bill material
    /// </summary>
    public class InventorBomItem : IDisposable
    {
        private BOMRow _row;

        private InventorDocument _document;

        public InventorBomItem(BOMRow row)
        {
            _row = row;
            Children = new List<InventorBomItem>();
        }

        /// <summary>
        /// Document reference for the bom item
        /// </summary>
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

        /// <summary>
        /// Children of the bom item
        /// </summary>
        public List<InventorBomItem> Children { get; set; }

        /// <summary>
        /// Qty of items for the bill
        /// </summary>
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