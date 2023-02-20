using Inventor;
using InventorWrapper.Documents;
using InventorWrapper.Drawings.Curves;
using InventorWrapper.Drawings.DrawingSheet;
using InventorWrapper.Drawings.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace InventorWrapper.Drawings
{
    public class InventorSheet : IDisposable
    {
        public Sheet _sheet;

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

        public InventorView AddBaseView(InventorDocument document, Curves.Point point, double scale, InventorViewOrientaionType viewOrientaionType, InventorDrawingViewStyle inventorDrawingViewStyle, string modelViewName = "")
        {
            var view = new InventorView(_sheet.DrawingViews.AddBaseView((_Document)document._document, point.CreatePoint(), scale, (ViewOrientationTypeEnum)viewOrientaionType, (DrawingViewStyleEnum)inventorDrawingViewStyle, modelViewName), this);

            Views.Add(view);

            return view;
        }

        public InventorView AddProjectedView(InventorView parentView, Curves.Point point, InventorDrawingViewStyle inventorDrawingViewStyle)
        {
            var view = new InventorView(_sheet.DrawingViews.AddProjectedView(parentView._view, point.CreatePoint(), (DrawingViewStyleEnum)inventorDrawingViewStyle), this);

            Views.Add(view);

            return view;
        }

        public InventorView AddProjectedView(InventorView parentView, ProjectedViewDirection viewDirection, double offset = 5, InventorDrawingViewStyle drawingViewStyle = InventorDrawingViewStyle.FromBaseDrawing)
        {
            var x = 0.00;
            var y = 0.00;

            switch (viewDirection)
            {
                case ProjectedViewDirection.Top:
                    x = parentView.Center.X;
                    y = parentView.Top + offset;
                    break;
                case ProjectedViewDirection.Left:
                    x = parentView.Left - offset;
                    y = parentView.Center.Y;
                    break;
                case ProjectedViewDirection.Bottom:
                    x = parentView.Center.X;
                    y = parentView.Bottom - offset;
                    break;
                case ProjectedViewDirection.Right:
                    x = parentView.Right + x;
                    y = parentView.Center.Y;
                    break;
            }

            return AddProjectedView(parentView, new Curves.Point(x, y), drawingViewStyle);
        }
        
        private void GetViews()
        {
            Views.Clear();

            foreach (DrawingView v in _sheet.DrawingViews)
            {
                Views.Add(new InventorView(v, this));
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
