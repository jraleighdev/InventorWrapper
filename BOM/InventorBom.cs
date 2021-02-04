using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Inventor;

namespace InventorWrapper.BOM
{
    public class InventorBom : IDisposable
    {
        private Inventor.BOM _bom;

        private Inventor.BOMView _view;

        private IEnumerable<string> _viewNames;

        public InventorBom(Inventor.BOM bom)
        {
            _bom = bom;
        }

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

        public bool StructureViewFirstLevelOnly
        {
            get => _bom.StructuredViewFirstLevelOnly;
            set => _bom.StructuredViewFirstLevelOnly = value;
        }

        public bool StructuredViewEnabled
        {
            get => _bom.StructuredViewEnabled;
            set => _bom.StructuredViewEnabled = value;
        }

        public bool PartsOnlyViewEnabled
        {
            get => _bom.PartsOnlyViewEnabled;
            set => _bom.PartsOnlyViewEnabled = value;
        }

        public string View
        {
            get => _view.Name;
            set => _view = _bom.BOMViews[value];
        }
        
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