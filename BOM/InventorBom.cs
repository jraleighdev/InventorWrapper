using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Inventor;

namespace InventorWrapper.BOM
{
    /// <summary>
    /// Inventor document 
    /// </summary>
    public class InventorBom : IDisposable
    {
        private Inventor.BOM _bom;

        private Inventor.BOMView _view;

        private IEnumerable<string> _viewNames;

        public InventorBom(Inventor.BOM bom)
        {
            _bom = bom;
        }

        /// <summary>
        /// Collection of the views for the bill
        /// </summary>
        public IEnumerable<string> Views
        {
            get
            {
                if (_viewNames == null)
                {
                    _viewNames = (from BOMView b in _bom.BOMViews select (b.Name));
                }

                return _viewNames;
            }
        }

        /// <summary>
        /// If the structured view of bill should only be the top level components
        /// </summary>
        public bool StructureViewFirstLevelOnly
        {
            get => _bom.StructuredViewFirstLevelOnly;
            set => _bom.StructuredViewFirstLevelOnly = value;
        }

        /// <summary>
        /// Gets and sets the if structure view is enabled
        /// </summary>
        public bool StructuredViewEnabled
        {
            get => _bom.StructuredViewEnabled;
            set => _bom.StructuredViewEnabled = value;
        }

        /// <summary>
        /// Gets and sets the if part view is enabled
        /// </summary>
        public bool PartsOnlyViewEnabled
        {
            get => _bom.PartsOnlyViewEnabled;
            set => _bom.PartsOnlyViewEnabled = value;
        }

        /// <summary>
        /// Sets the active view
        /// </summary>
        public string View
        {
            get => _view.Name;
            set => _view = _bom.BOMViews[value];
        }
        
        /// <summary>
        /// Gets all the bill items in the active assembly
        /// </summary>
        /// <returns></returns>
        public List<InventorBomItem> GetBill()
        {
            var tempList = new List<InventorBomItem>();

            foreach (BOMRow row in _view.BOMRows)
            {
                var bomItem = new InventorBomItem(row);

                if (row.ChildRows != null && row.ChildRows.Count > 0)
                {
                    GetChildren(row.ChildRows, bomItem);
                }

                tempList.Add(bomItem);
            }

            return tempList;
        }

        private void GetChildren(BOMRowsEnumerator rows, InventorBomItem parent)
        {
            foreach (BOMRow row in rows)
            {
                var bomItem = new InventorBomItem(row);

                parent.Children.Add(bomItem);

                if (row.ChildRows != null && row.ChildRows.Count > 0)
                {
                    GetChildren(row.ChildRows, bomItem);
                }
            }
        }

        public void Dispose()
        {
            if (_bom == null) return;
            Marshal.ReleaseComObject(_bom);
            _bom = null;
        }
    }
}