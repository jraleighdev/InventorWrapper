using Inventor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Drawings
{
    public class InventorSheet : IDisposable
    {
        private Sheet _sheet;

        public List<InventorView> Views { get; set; }

        public void Activate() => _sheet.Activate();

        public void AddBorder() => _sheet.AddDefaultBorder();

        public void Delete() => _sheet.Delete();

        public double Height => _sheet.Height;

        public double Width => _sheet.Width;

        public string Name => _sheet.Name;

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
