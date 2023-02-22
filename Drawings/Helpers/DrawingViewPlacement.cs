using InventorWrapper.Drawings.Curves;
using InventorWrapper.Drawings.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InventorWrapper.Drawings.Helpers
{
    /// <summary>
    /// Helps align drawings on sheet based on the left bottom corner being the origin.
    /// </summary>
    public class DrawingViewPlacement
    {
        public InventorSheet Sheet { get; private set; }

        public List<InventorView> Views { get; private set; }

        public List<Exception> Errors { get; private set; }

        public double Scale { get; private set; }

        public double LeftOffset { get; set; }

        public double RightOffset { get; set; }

        public double TopOffset { get; set; }

        public double BottomOffset { get; set; }

        public double ViewOffset { get; private set; }

        public double ViewSpacing { get; private set; }

        public double AvailableSpaceX => Sheet.Width - LeftOffset - RightOffset;

        public double AvailableSpaceY => Sheet.Height - TopOffset - BottomOffset;

        /// <summary>
        /// Bottom Left point
        /// </summary>
        /// <returns></returns>
        public Point Datum => new Point(LeftOffset, BottomOffset);

        public Point TopLeft => new Point(LeftOffset, Sheet.Height - TopOffset);

        public Point TopRight => new Point(Sheet.Width - RightOffset, Sheet.Height - TopOffset);

        public Point BottomRight => new Point(Sheet.Width - RightOffset, BottomOffset);

        public Point Center => new Point((TopLeft.X + Datum.X) / 2, (TopLeft.Y + Datum.Y) / 2);

        public DrawingViewPlacement(InventorSheet sheet, List<InventorView> views, double scale, double leftOffset, double bottomOffset, double rightOffset, double topOffset, double viewSpacing = .75, double viewOffset = .5)
        {
            Errors = new List<Exception>();
            Sheet = sheet;
            Views = views;
            Scale = scale;
            LeftOffset = leftOffset;
            RightOffset = rightOffset;
            TopOffset = topOffset;
            BottomOffset = bottomOffset;
            ViewOffset = viewOffset;
            ViewSpacing = viewSpacing;
        }

        public void LocateAndScale()
        {
            // Get intitial data before scale is set
            var data = GetData();

            // Set scale
            CalcScale(data);

            LocateViewsAlongXAxis();

            LocateViewsAlongYAxis();
        }

        public void ShiftViews(ShiftDirection shiftDirection)
        {
            switch (shiftDirection)
            {
                case ShiftDirection.Horizontal:
                    LocateViewsAlongXAxis();
                    break;
                case ShiftDirection.Vertical:
                    LocateViewsAlongYAxis();
                    break;
            }
        }

        public void LocateViewsAlongXAxis()
        {
            var viewData = GetData();

            var viewsXSorted = Views.OrderBy(view => view.Center.X);

            var adjustedView = new List<InventorView>();

            InventorView lastMovedView = null;

            foreach (var view in viewsXSorted)
            {
                if (adjustedView.Contains(view)) continue;

                var viewsInLineWithCurrentViewX = viewsXSorted.Where(v => Math.Abs(v.Center.X - view.Center.X) < ViewOffset);

                var moved = false;

                foreach (var fv in viewsInLineWithCurrentViewX)
                {
                    adjustedView.Add(fv);

                    InventorApplication.ActiveDocument.Update();

                    var newPoint = GetNewXPoint(fv, lastMovedView, GetXSpacing(viewData.CombinedWidth, viewData.HorQty), moved);

                    try
                    {
                        fv.Center = newPoint;

                        InventorApplication.ActiveDocument.Update();

                        if (Math.Abs(fv.Center.X - newPoint.X) < ViewOffset)
                        {
                            lastMovedView = fv;
                            moved = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Errors.Add(ex);
                    }
                }
            }
        }

        public void LocateViewsAlongYAxis()
        {
            var viewData = GetData();

            var viewsYSorted = Views.OrderBy(view => view.Center.Y);

            var adjustedView = new List<InventorView>();

            InventorView lastMovedView = null;

            foreach (var view in viewsYSorted)
            {
                if (adjustedView.Contains(view)) continue;

                var viewsInLineWithCurrentViewY = viewsYSorted.Where(v => Math.Abs(v.Center.Y - view.Center.Y) < ViewOffset);

                var moved = false;

                foreach (var fv in viewsInLineWithCurrentViewY)
                {
                    adjustedView.Add(fv);

                    InventorApplication.ActiveDocument.Update();

                    var newPoint = GetNewYPoint(fv, lastMovedView, GetYSpacing(viewData.CombinedHeight, viewData.VertQty), moved);

                    try
                    {
                        fv.Center = newPoint;

                        InventorApplication.ActiveDocument.Update();

                        if (Math.Abs(fv.Center.Y - newPoint.Y) < ViewOffset)
                        {
                            lastMovedView = fv;
                            moved = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Errors.Add(ex);
                    }
                }
            }
        }

        private Point GetNewXPoint(InventorView currentView, InventorView lastView, double spacingX, bool verticalAligned)
        {
            if (lastView == null)
            {
                return new Point(Datum.X + spacingX + (currentView.Width / 2), currentView.Center.Y);
            }
            else if (verticalAligned)
            {
                return new Point(lastView.Center.X, currentView.Center.Y);
            }
            
            return new Point(lastView.Center.X + spacingX + (currentView.Width / 2) + (lastView.Width / 2), currentView.Center.Y);
        }

        private Point GetNewYPoint(InventorView currentView, InventorView lastView, double spacingY, bool horizontalAligned)
        {
            if (lastView == null)
            {
                return new Point(currentView.Center.X, Datum.Y + spacingY + (currentView.Height / 2));
            }
            else if (horizontalAligned)
            {
                return new Point(currentView.Center.X, lastView.Center.Y);
            }

            return new Point(currentView.Center.X, lastView.Center.Y + spacingY + (currentView.Height / 2) + (lastView.Height / 2)); 
        }

        private void CalcScale(ViewData viewData)
        {
            if (viewData.CombinedHeight < 0.01 && viewData.CombinedWidth < 0.01) return;

            var firstView = Views[0];

            var horizontalBuffer = viewData.HorQty + 1;
            var verticalBuffer = viewData.VertQty + 1;

            var hScale = (AvailableSpaceX - (horizontalBuffer * ViewSpacing)) / (viewData.CombinedWidth / firstView.Scale);
            var vScale = (AvailableSpaceY - (verticalBuffer * ViewSpacing)) / (viewData.CombinedHeight / firstView.Scale);

            double scale;

            if (hScale <= 0 && vScale <= 0)
            {
                scale = firstView.Scale;
            }
            else if (hScale <= 0 || vScale <= 0)
            {
                scale = Math.Max(hScale, vScale);
            }
            else
            {
                scale = Math.Min(hScale, vScale);
            }

            foreach (var view in Views)
            {
                if (view.ViewType == InventorDrawingViewType.StandardDrawing)
                {
                    view.Scale = scale;
                }
                else if (!view.ScaleFromBase)
                {
                    view.Scale = scale;
                }
            }

            InventorApplication.ActiveDocument.Update();
        }


        private ViewData GetData()
        {
            if (Views.Count == 0)
            {
                throw new Exception("No views on sheet to process");
            }

            var firstView = Views[0];

            var combinedHeight = firstView.Height;
            var combinedWidth = firstView.Width;
            var horizQty = 1;
            var vertQty = 1;

            foreach (var view in Views)
            {
                if (view == firstView) continue;

                if (Math.Abs(view.Center.X - firstView.Center.X) < ViewOffset)
                {
                    combinedHeight += view.Height;
                    vertQty++;
                }

                if (Math.Abs(view.Center.Y - firstView.Center.Y) < ViewOffset)
                {
                    combinedWidth += view.Width;
                    horizQty++;
                }
            }

            return new ViewData(combinedWidth, combinedHeight, horizQty, vertQty);
        }


        private double GetXSpacing(double combinedWidth, int qty) => Math.Abs((AvailableSpaceX - combinedWidth) / (qty + 1));

        private double GetYSpacing(double combinedHeight, int qty) => Math.Abs((AvailableSpaceY - combinedHeight)/ (qty + 1));

        internal struct ViewData
        {
            public ViewData(double combinedWidth, double combinedHeight, int horQty, int vertQty)
            {
                CombinedWidth = combinedWidth;
                CombinedHeight = combinedHeight;
                HorQty = horQty;
                VertQty = vertQty;
            }

            public double CombinedWidth { get; private set; }

            public double CombinedHeight { get; private set; }

            public int HorQty { get; private set; }

            public int VertQty { get; private set; }
        }

    }
}
