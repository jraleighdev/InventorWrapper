using Inventor;
using InventorWrapper.Drawings.Enums;
using InventorWrapper.Drawings.Interfaces;
using InventorWrapper.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Drawings.Curves
{
    /// <summary>
    /// Inventor drawing curve
    /// </summary>
    public class InventorDrawingCurve : IDisposable
    {
        /// <summary>
        /// Source inventor drawing curve
        /// </summary>
        public DrawingCurve _curve;
        
        /// <summary>
        /// Refrence to the sheet for creating geometry intent
        /// </summary>
        public  Sheet _sheet;

        /// <summary>
        /// If the curve was found
        /// </summary>
        private bool found;

        /// <summary>
        /// Range box for the curve
        /// </summary>
        private Box2d _rangeBox;

        /// <summary>
        /// Type of curve
        /// </summary>
        public CurveTypes CurveType { get; }
       
        /// <summary>
        /// Start point of the curve returns null on circular curves
        /// </summary>
        public GeometryPoint StartPoint => _curve.StartPoint == null ? null : new GeometryPoint(_curve.StartPoint, this, PointType.EndPoint);

        /// <summary>
        /// End point of the curve returns null on circular curves
        /// </summary>
        public GeometryPoint EndPoint => _curve.EndPoint == null ? null :  new GeometryPoint(_curve.EndPoint, this, PointType.EndPoint);

        /// <summary>
        /// Top left point of the curve 
        /// </summary>
        public GeometryPoint TopLeftPoint => new GeometryPoint(_rangeBox.MinPoint.X, _rangeBox.MaxPoint.Y, this, PointType.TopLeftPoint);

        /// <summary>
        /// Top Right point of the curve
        /// </summary>
        public GeometryPoint TopRightPoint => new GeometryPoint(_rangeBox.MaxPoint, this, PointType.TopRightPoint);

        /// <summary>
        /// Bottom Left Point of the curve
        /// </summary>
        public GeometryPoint BottomLeftPoint => new GeometryPoint(_rangeBox.MinPoint, this, PointType.BottomLeftPoint);

        /// <summary>
        /// Bottom Right point of the curve
        /// </summary>
        public GeometryPoint BottomRightPoint => new GeometryPoint(_rangeBox.MaxPoint.X, _rangeBox.MinPoint.Y, this, PointType.BottomRightPoint);

        /// <summary>
        /// Max x vertex point of a circular curve
        /// </summary>
        public GeometryPoint RightMidPoint => new GeometryPoint(_rangeBox.MaxPoint.X, MidY, this, PointType.VertexPoint);
        
        /// <summary>
        /// Max x vertex point of a circular curve
        /// </summary>
        public GeometryPoint TopMidPoint => new GeometryPoint(MidX, _rangeBox.MaxPoint.Y, this, PointType.VertexPoint);
        
        /// <summary>
        /// Max x vertex point of a circular curve
        /// </summary>
        public GeometryPoint LeftMidPoint => new GeometryPoint(_rangeBox.MinPoint.X, MidY, this, PointType.VertexPoint);
        
        /// <summary>
        /// Max x vertex point of a circular curve
        /// </summary>
        public GeometryPoint BottomMidPoint => new GeometryPoint(MidX, _rangeBox.MinPoint.Y, this, PointType.VertexPoint);

        /// <summary>
        /// Center point or midpoint of the curve
        /// </summary>
        public GeometryPoint CenterPoint =>
            _curve.CenterPoint == null ? null : new GeometryPoint(_curve.CenterPoint, this, PointType.CenterPoint);

        public GeometryPoint MidPoint => _curve.MidPoint == null ? null : new GeometryPoint(_curve.MidPoint, this, PointType.MidPoint);

        /// <summary>
        /// Returns all the points on the curve that are not null
        /// </summary>
        /// <returns></returns>
        public List<GeometryPoint> Points()
        {
            // Put all the points in a list
            var tempList = new List<GeometryPoint>
            {
                StartPoint,
                EndPoint,
                TopLeftPoint,
                TopRightPoint,
                BottomLeftPoint,
                BottomRightPoint,
                CenterPoint,
                MidPoint
            };

            // remove all the null points
            tempList.RemoveAll(point => point == null);

            // return the temp list 
            return tempList;
        }
       
        /// <summary>
        /// Constructs the inventor curve and adds reference to the source sheet.
        /// </summary>
        /// <param name="curve"></param>
        /// <param name="sheet"></param>
        public InventorDrawingCurve(DrawingCurve curve, Sheet sheet)
        {
            _curve = curve;
            _sheet = sheet;
            _rangeBox = _curve.Evaluator2D.RangeBox;
            CurveType = (CurveTypes)_curve.CurveType;
        }

        /// <summary>
        /// Gets the mid x value of the curves range box
        /// </summary>
        private double MidX => _rangeBox.MaxPoint.X - (_rangeBox.MaxPoint.X - _rangeBox.MinPoint.X) / 2;

        /// <summary>
        /// Gets the mid y value of the curves range box
        /// </summary>
        private double MidY => _rangeBox.MaxPoint.Y - (_rangeBox.MaxPoint.Y - _rangeBox.MinPoint.Y) / 2;
        
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
