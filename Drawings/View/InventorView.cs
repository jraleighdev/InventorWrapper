﻿using Inventor;
using InventorWrapper.Components;
using InventorWrapper.Documents;
using InventorWrapper.Drawings.Curves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using InventorWrapper.Drawings.Dimensions;
using InventorWrapper.Drawings.Dimensions.OrdinateDims;
using InventorWrapper.Drawings.Enums;
using InventorWrapper.Extensions.Curves;
using Point = InventorWrapper.Drawings.Curves.Point;
using InventorWrapper.Drawings.Annotations;

namespace InventorWrapper.Drawings
{
    public class InventorView : IDisposable
    {
        public DrawingView _view;

        protected Sheet _sheet => Parent._sheet;

        private InventorDocument _document;

        /// <summary>
        /// List of exceptions gathered during curve collection.
        /// </summary>
        public List<Exception> Exceptions { get; set; }

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

        public string ActiveDesignViewRep => _view.ActiveDesignViewRepresentation;

        public void SetDesignViewRepresentation(string value, bool associative)
        {
            _view.SetDesignViewRepresentation(value, associative);
        }

        public void SetLevelOfDetail(string value)
        {
            _view.ActiveLevelOfDetailRepresentation = value;
        }

        public string ActiveLevelOfDetail => _view.ActiveLevelOfDetailRepresentation;
        
        public InventorDrawingViewType ViewType => (InventorDrawingViewType)_view.ViewType;

        public bool Aligned
        {
            get => _view.Aligned;
            set => _view.Aligned = value;
        }

        public bool IsProjected => ViewType == InventorDrawingViewType.ProjectedDrawing;

        public bool IsDetail => ViewType == InventorDrawingViewType.DetailDrawing;

        public bool IsSection => ViewType == InventorDrawingViewType.SectionDrawing;

        public bool Associative => _view.DesignViewAssociative;

        public bool ScaleFromBase
        {
            get => _view.ScaleFromBase;
            set => _view.ScaleFromBase = value;
        }

        /// <summary>
        /// Current scale of the view 
        /// </summary>
        public double Scale
        {
            get => _view.Scale;
            set
            {
                if (value <= 0)
                {
                    _view.Scale = .01;
                }
                else
                {
                    _view.Scale = value;

                }
            }
        }

        public Point Center
        {
            get => new Point(_view.Center);
            set => _view.Center = value.CreatePoint();
        }

        /// <summary>
        /// Location of the view
        /// </summary>
        public Point Point
        {
            get => new Point(_view.Position);
            set => _view.Position = value.CreatePoint();
        }

        public InventorSheet Parent { get; private set; }

        public InventorView(DrawingView view, InventorSheet parent)
        {
            _view = view;
            Parent = parent;
            Exceptions = new List<Exception>();
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
        public List<InventorDrawingCurve> GetCurves(InventorComponent component = null)
        {
            var curveEnum = component == null ? _view.DrawingCurves : _view.DrawingCurves[component._component];

            var curves = new List<InventorDrawingCurve>();

            foreach (DrawingCurve curve in curveEnum)
            {
                if (curve == null) continue;

                curves.Add(new InventorDrawingCurve(curve, _sheet, component));
            }

            return curves;
        }

        public List<InventorDrawingCurve> GetCurves(IEnumerable<InventorComponent> components)
        {
            if (components == null) return null;

            var curves = new List<InventorDrawingCurve>();

            foreach (var component in components)
            {
                if (component == null || component.Suppressed) continue;

                try
                {
                    var curveEnum = _view.DrawingCurves[component._component];

                    if (curveEnum == null || curveEnum.Count == 0) continue;

                    foreach (DrawingCurve c in curveEnum)
                    {
                        if (c == null) continue;

                        curves.Add(new InventorDrawingCurve(c, _sheet, component));
                    }
                }
                catch (Exception ex)
                {
                    Exceptions.Add(ex);
                }
            }

            return curves;
         }

        #region Dimensions

        /// <summary>
        /// Adds general dimension to a drawing
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <param name="dimensionType"></param>
        /// <param name="dimTextLocation"></param>
        /// <param name="text"></param>
        public InventorLinearGeneralDim AddGeneralDimension(GeometryPoint point1, GeometryPoint point2, InventorDimensionType dimensionType, Curves.Point dimTextLocation, string text = "")
        {
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

                return new InventorLinearGeneralDim(generalDimension);
            }
            catch (Exception e)
            {
                throw new Exception("Could not add general dimension", e);
            }
        }
        
        /// <summary>
        /// Adds general dimension to a drawing
        /// </summary>
        /// <param name="point1"></param>
        /// <param name="point2"></param>
        /// <param name="dimensionType"></param>
        /// <param name="viewSide"></param>
        /// <param name="adjustment"></param>
        /// <param name="text"></param>
        public InventorLinearGeneralDim AddGeneralDimension(GeometryPoint point1, GeometryPoint point2, InventorDimensionType dimensionType, ViewSide viewSide, double adjustment = 0, string text = "")
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

                return new InventorLinearGeneralDim(generalDimension);
            }
            catch (Exception e)
            {
                throw new Exception("Could not add general dimension", e);
            }
        }

        /// <summary>
        /// Add a ordinate dimension set to the view
        /// </summary>
        /// <param name="points"></param>
        /// <param name="dimensionType"></param>
        /// <param name="viewSide"></param>
        /// <param name="continuousRunning"></param>
        /// <param name="adjustment"></param>
        public InventorOrdinateDimensionSet AddOrdinateDimension(List<GeometryPoint> points, InventorDimensionType dimensionType,
            ViewSide viewSide, bool continuousRunning = true, double adjustment = 0)
        {
            var collection = InventorApplication.CreateObjectCollection(points);

            var dimTextLocation = DrawingTextLocator(dimensionType, viewSide, adjustment);

            var dim = _sheet.DrawingDimensions.OrdinateDimensionSets.Add(collection, dimTextLocation.CreatePoint(), (DimensionTypeEnum)dimensionType);

            dim.ContinuousRunning = continuousRunning;

            Marshal.ReleaseComObject(collection);

            return new InventorOrdinateDimensionSet(dim);
        }

        /// <summary>
        /// Adds a diameter dim the drawing
        /// </summary>
        /// <param name="point"></param>
        /// <param name="viewSide"></param>
        /// <param name="xAdjust"></param>
        /// <param name="yAdjust"></param>
        /// <returns></returns>
        public InventorDiameterDimension AddDiameterDim(GeometryPoint point, ViewSide viewSide, double xAdjust = 1, double yAdjust = 1)
        {
            return new InventorDiameterDimension(_sheet.DrawingDimensions.GeneralDimensions
                .AddDiameter(new Point(point.X + xAdjust, point.Y + yAdjust).CreatePoint(), point.CreateIntent()));
        }

        private Point DrawingTextLocator(InventorDimensionType dimensionType, ViewSide side, double adjustment)
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

        #region Center Lines

        /// <summary>
        /// Creates line between two points
        /// </summary>
        /// <param name="pointOne"></param>
        /// <param name="pointTwo"></param>
        /// <exception cref="Exception"></exception>
        public InventorCenterLine CreateCenterLine(GeometryPoint pointOne, GeometryPoint pointTwo)
        {
            if (pointOne == null || pointTwo == null)
            {
                throw new Exception("One or Both of the given points is null");
            }
            
            var centerEntities = InventorApplication.CreateObjectCollection(new List<GeometryPoint> { pointOne, pointTwo});

            return new InventorCenterLine(_sheet.Centerlines.Add(centerEntities), _sheet);
        }

        /// <summary>
        /// Creates center marks for the given points
        /// </summary>
        /// <param name="points"></param>
        public InventorCenterLine CreateCenterLine(List<GeometryPoint> points)
        {
            var centerEntities = InventorApplication.CreateObjectCollection(points);

            return new InventorCenterLine(_sheet.Centerlines.Add(centerEntities), _sheet);
        }

        public InventorCenterLine CreateCenterLine(InventorDrawingCurve curveOne, InventorDrawingCurve curveTwo)
        {
            if (curveOne == null || curveTwo == null)
            {
                throw new Exception("One or bot of the given curves are null");
            }

            return new InventorCenterLine(_sheet.Centerlines.AddBisector(curveOne.CreateIntent(), curveTwo.CreateIntent()), _sheet);
        }

        /// <summary>
        /// Creates center lines based on optional parameters
        /// If vertical and horizontal are false then center lines created
        /// </summary>
        /// <param name="points">List of points</param>
        /// <param name="vertical">Create vertical center lines between points that are on the same y axis</param>
        /// <param name="horizontal">Create horizontal center lines between points that are on the same x axis</param>
        /// <param name="centerMarks">Create center marks on the given points</param>
        public List<InventorCenterLine> CreateCenterLines(List<GeometryPoint> points, bool vertical = true, bool horizontal = true,
            bool centerMarks = true)
        {
            var tempList = new List<InventorCenterLine>();

            var xPoints = new List<GeometryPoint>();
            var yPoints = new List<GeometryPoint>();

            points.RemoveAll(p => p == null);
            
            xPoints.AddRange(points.RemoveDuplicateX());
            
            yPoints.AddRange(points.RemoveDuplicateY());

            if (vertical)
            {
                foreach (var point in xPoints)
                {
                    var verticalPoints = new List<GeometryPoint>();
                    
                    verticalPoints.AddRange(points.Where(p => Math.Abs(point.X - p.X) < 0.005));
                    
                    if (verticalPoints.Count < 2) continue;
                    
                    tempList.Add(CreateCenterLine(verticalPoints));
                }
            }

            if (horizontal)
            {
                foreach (var point in yPoints)
                {
                    var horizontalPoints = new List<GeometryPoint>();
                    
                    horizontalPoints.AddRange(points.Where(p => Math.Abs(point.Y - p.Y) < 0.005));
                    
                    if (horizontalPoints.Count < 2) continue;
                    
                    tempList.Add(CreateCenterLine(horizontalPoints));
                }
            }
            
            if (centerMarks) CreateCenterMarks(points);

            return tempList;
        }

        /// <summary>
        /// Adds center marks to all points in the given list
        /// All null points are ignored
        /// </summary>
        /// <param name="points"></param>
        /// <param name="extensionLines"></param>
        public void CreateCenterMarks(List<GeometryPoint> points, bool extensionLines = false)
        {
            points.RemoveAll(point => point == null || point.PointType != PointType.CenterPoint);

            foreach (var p in points)
            {
                var c = _sheet.Centermarks.Add(p.CreateIntent());
                c.ExtensionLinesVisible = extensionLines;
            }   
        }

        #endregion

        #region Leaders

        /// <summary>
        /// Creates center line direction is based on center
        /// </summary>
        /// <param name="point"></param>
        /// <param name="text"></param>
        /// <param name="offset"></param>
        /// <param name="optionalXCenter">Optional x center the leader will face direction that the point is in relation to center</param>
        /// <param name="optionalYCenter">Optional y center the leader will face direction that the point is in relation to center</param>
        public void AddLeader(GeometryPoint point, string text, double offset = .25, Point optionalXCenter = null, Point optionalYCenter = null)
        {
            var centerX = optionalXCenter ?? Center;
            var centerY = optionalYCenter ?? Center;

            var x = point.X > centerX.X ? point.X + offset : point.X - offset;
            var y = point.Y > centerY.Y ? point.Y + offset : point.Y - offset;

            var textPoint = new Point(x, y);

            var collection = InventorApplication.CreateObjectCollection();

            collection.Add(textPoint.CreatePoint());
            collection.Add(point.CreateIntent());
            
            _sheet.DrawingNotes.LeaderNotes.Add(collection, text);
        }

        #endregion

        public void Delete() => _view.Delete();
        
        public void Dispose()
        {
            if (_view != null)
            {
                Marshal.ReleaseComObject(_view);
            }
        }
    }
}
