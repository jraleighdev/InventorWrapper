using Inventor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Drawings.DrawingSheet
{
    public class InventorBorder : IDisposable
    {
        public Border _border;

        public Curves.Point BottomLeft => new Curves.Point(_border.RangeBox.MinPoint);

        public Curves.Point BottomRight => new Curves.Point(_border.RangeBox.MaxPoint.X, _border.RangeBox.MinPoint.Y);

        public Curves.Point TopRight => new Curves.Point(_border.RangeBox.MaxPoint);

        public Curves.Point TopLeft => new Curves.Point(_border.RangeBox.MinPoint.X, _border.RangeBox.MaxPoint.Y);

        public double Height => Math.Abs(TopLeft.Y - BottomLeft.Y);

        public double Width => Math.Abs(BottomRight.X - BottomLeft.X);

        public string Name
        {
            get => _border.Name;
            set => _border.Name = value;
        }

        public InventorBorder(Border border)
        {
            _border = border;
        }

        public void Dispose()
        {
            if (_border != null)
            {
                Marshal.ReleaseComObject(_border);
                _border = null;
            }
        }
    }
}
