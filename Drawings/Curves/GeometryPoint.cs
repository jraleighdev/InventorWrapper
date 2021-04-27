using Inventor;
using InventorWrapper.Drawings.Enums;

namespace InventorWrapper.Drawings.Curves
{
    public class GeometryPoint : Point
    {
        public InventorDrawingCurve Curve { get; private set; }
        
        public PointType PointType { get; private set; }

        /// <summary>
        /// Create geometry intent to apply dimensions
        /// </summary>
        public GeometryIntent CreateIntent()
        {
            return Curve._sheet.CreateGeometryIntent(Curve._curve, CreatePoint());
        }

        /// <summary>
        /// Create the geometry intent based on x and y values
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="curve"></param>
        /// <param name="pointType"></param>
        public GeometryPoint(double x, double y, InventorDrawingCurve curve, PointType pointType) : base(x, y)
        {
            Curve = curve;
            PointType = pointType;
        }

        /// <summary>
        /// Creates the geometry intent based on a source inventor point
        /// </summary>
        /// <param name="point"></param>
        /// <param name="curve"></param>
        /// <param name="pointType"></param>
        public GeometryPoint(Point2d point, InventorDrawingCurve curve, PointType pointType) : base(point)
        {
            Curve = curve;
            PointType = pointType;
        }
        
        
    }
}