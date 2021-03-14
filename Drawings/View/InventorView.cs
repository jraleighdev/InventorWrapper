using Inventor;
using InventorWrapper.Components;
using InventorWrapper.Documents;
using InventorWrapper.Drawings.Curves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using InventorWrapper.Drawings.Enums;
using Point = InventorWrapper.Drawings.Curves.Point;

namespace InventorWrapper.Drawings
{
    public class InventorView : IDisposable
    {
        public DrawingView _view;

        public Sheet _sheet;

        private InventorDocument _document;

        /// <summary>
        /// View Name
        /// </summary>
        public string Name => _view.Name;

        /// <summary>
        /// Height of the view
        /// </summary>
        public double Height => _view.Height;

        /// <summary>
        /// Width of the view
        /// </summary>
        public double Width => _view.Width;

        /// <summary>
        /// Left point of the view
        /// </summary>
        public double Left => _view.Left;

        /// <summary>
        /// Right point of the view
        /// </summary>
        public double Right => _view.Left + Width;

        /// <summary>
        /// Top point of the view
        /// </summary>
        public double Top => _view.Top;

        /// <summary>
        /// Bottom point of the view
        /// </summary>
        public double Bottom => _view.Top - _view.Height;

        /// <summary>
        /// Current scale of the view 
        /// </summary>
        public double Scale => _view.Scale;

        public Point Center
        {
            get => new Point(_view.Center);
            set => new Point(value.X, value.Y);
        }

        /// <summary>
        /// Location of the view
        /// </summary>
        public Point Point
        {
            get => new Point(_view.Position);
            set => new Point(value.X, value.Y);
        }

        public InventorView(DrawingView view)
        {
            _view = view;
            _sheet = view.Parent;
        }

        /// <summary>
        /// Source document for the view 
        /// </summary>
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

        /// <summary>
        /// Gets the referenced components from the view
        /// </summary>
        /// <param name="recurse"></param>
        /// <returns></returns>
        public InventorComponents GetInventorComponents(bool recurse = true)
        {
            if (Document.IsAssemblyDoc)
            {
                return new InventorComponents(Document.GetAssemblyDocument(), recurse);
            }
            else
            {
                throw new Exception("Cannot get components document must be an assembly document");
            }
        }

        /// <summary>
        /// Gets the curves for the given component if no component is supplied return all the curves
        /// </summary>
        /// <param name="component"></param>
        /// <returns></returns>
        public InventorDrawingCurves GetCurves(InventorComponent component = null)
        {
            return new InventorDrawingCurves(component != null ? 
                     _view.DrawingCurves[component._component] : 
                     _view.DrawingCurves, _sheet);
        }

        #region Dimensions

        /// <summary>
        /// Adds general dimension to a drawing
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <param name="dimensionType"></param>
        /// <param name="viewSide"></param>
        /// <param name="adjustment"></param>
        /// <param name="text"></param>
        public void AddGeneralDimension(GeometryPoint point1, GeometryPoint point2, InventorDimensionType dimensionType, ViewSide viewSide, double adjustment = 0, string text = "")
        {
            var dimTextLocation = DrawingTextLocator(dimensionType, viewSide, adjustment);

            try
            {
                var generalDimension = _sheet.DrawingDimensions.GeneralDimensions.AddLinear(dimTextLocation.CreatePoint(),
                    point1.CreateIntent(), point2.CreateIntent(),
                    (DimensionTypeEnum)dimensionType);
            
                generalDimension.CenterText();

                if (!string.IsNullOrEmpty(text))
                {
                    generalDimension.HideValue = true;
                    generalDimension.Text.FormattedText = text;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Could not add general dimension", e);
            }
        }

        public Point DrawingTextLocator(InventorDimensionType dimensionType, ViewSide side, double adjustment)
        {
            double x = 0;
            double y = 0;

            switch (dimensionType)
            {
                case InventorDimensionType.HorizontalDimensionType:

                    x = Center.X;
                    
                    switch (side)
                    {
                        case ViewSide.Top:
                            y = Height / 2 + Center.Y + 0.5 + adjustment;
                            break;
                        case ViewSide.Bottom:
                            y = Center.Y - (Height / 2) - .5 - adjustment;
                            break;
                    }
                    break;
                case InventorDimensionType.VerticalDimensionType:

                    y = Center.Y;
                    
                    switch (side)
                    {
                        case ViewSide.Right:
                            x = Width / 2 + Center.X + .5 + adjustment;
                            break;
                        case ViewSide.Left:
                            x = Center.X - (Width / 2) - .5 - adjustment;
                            break;
                    }
                    break;
            }

            return new Point(x, y);
        }
        
        #endregion
        
        

        public void Dispose()
        {
            if (_view != null)
            {
                Marshal.ReleaseComObject(_view);
            }
        }
    }
}
