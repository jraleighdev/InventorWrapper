using Inventor;
using InventorWrapper.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Drawings
{
    public class InventorView : IDisposable
    {
        public DrawingView _view;

        private InventorDocument _document;

        public string Name => _view.Name;

        public double Height => _view.Height;

        public double Width => _view.Width;

        public double Left => _view.Left;

        public double Right => _view.Left + Width;

        public double Top => _view.Top;

        public double Bottom => _view.Top - _view.Height;

        public double Scale => _view.Scale;

        public Point Point
        {
            get => new Point(_view.Position);
            set => Point.CreatePoint();
        }

        public InventorView(DrawingView view)
        {
            _view = view;
        }

        public InventorDocument Document
        {
            get
            {
                if (_document == null)
                {
                    _document = new InventorDocument(_view.ReferencedDocumentDescriptor.ReferencedDocument as Document);
                }

                return _document;
            }
        }

        public void Dispose()
        {
            if (_view != null)
            {
                Marshal.ReleaseComObject(_view);
            }
        }
    }
}
