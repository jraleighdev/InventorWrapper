using Inventor;
using InventorWrapper.Drawings.DrawingSheet;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace InventorWrapper.Drawings
{
    public class InventorSheet : IDisposable
    {
        private Sheet _sheet;

        private InventorTitleBlock _titleBlock;

        public List<InventorView> Views { get; set; }

        public void Activate() => _sheet.Activate();

        public void AddBorder() => _sheet.AddDefaultBorder();

        public void Delete() => _sheet.Delete();

        public double Height => _sheet.Height;

        public double Width => _sheet.Width;

        public string Name => _sheet.Name;

        public InventorTitleBlock TitleBlock
        {
            get
            {
                if (_titleBlock == null)
                {
                    _titleBlock = new InventorTitleBlock(_sheet.TitleBlock);
                }

                return _titleBlock;
            }
        }

        public InventorSheet(Sheet sheet)
        {
            _sheet = sheet;
            Views = new List<InventorView>();

            GetViews();
        }

        private void GetViews()
        {
            Views.Clear();

            foreach (DrawingView v in _sheet.DrawingViews)
            {
                Views.Add(new InventorView(v));
            }
        }

        public void Dispose()
        {
            if (_sheet == null)
            {
                Marshal.ReleaseComObject(_sheet);
            }
        }
    }
}
