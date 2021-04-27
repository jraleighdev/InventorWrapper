using Inventor;
using InventorWrapper.Drawings.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Point = InventorWrapper.Drawings.Curves.Point;

namespace InventorWrapper.Drawings.DrawingSheet
{
    public class InventorTitleBlock : ILocationEntity, IDisposable
    {
        private TitleBlock _title;
        
        public InventorTitleBlock(TitleBlock title)
        {
            _title = title;

        }

        public string Name
        {
            get => _title.Name;
            set => _title.Name = value;
        }

        public double Height => Math.Abs(_title.RangeBox.MaxPoint.Y - _title.RangeBox.MinPoint.Y);

        public double Width => Math.Abs(_title.RangeBox.MaxPoint.X - _title.RangeBox.MinPoint.X);

        public Point TopLeftPoint => new Point(_title.RangeBox.MinPoint.X, _title.RangeBox.MaxPoint.Y);

        public Point TopRightPoint => new Point(_title.RangeBox.MaxPoint);

        public Point BottomLeftPoint => new Point(_title.RangeBox.MinPoint);

        public Point BottomRightPoint => new Point(_title.RangeBox.MaxPoint.X, _title.RangeBox.MinPoint.Y);

        public Point CenterPoint => new Point((TopRightPoint.X + BottomLeftPoint.X) / 2, (TopRightPoint.Y + BottomLeftPoint.Y) / 2);

        public Point Position
        {
            get => new Point(_title.Position);
            set => new Point(value.X, value.Y);
        }

        /// <summary>
        /// Deletes the title block from the sheet
        /// </summary>
        public void Delete()
        {
            _title.Delete();

            // TODO Verify if dispose should be ran
            // Dispose();
        }

        public void Dispose()
        {
            if (_title != null)
            {
                Marshal.ReleaseComObject(_title);

                _title = null;
            }
        }
    }
}
