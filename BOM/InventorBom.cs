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
        public List<InventorBomItem> GetGill()
        {
            return (from BOMRow row in _view.BOMRows select new InventorBomItem(row)).ToList();
        }
        
        public void Dispose()
        {
            if (_bom == null) return;
            Marshal.ReleaseComObject(_bom);
            _bom = null;
        }
    }
}