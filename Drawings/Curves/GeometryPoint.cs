using Inventor;

namespace InventorWrapper.Drawings.Curves
{
    public class GeometryPoint : Point
    {
        private readonly InventorDrawingCurve _curve;

        /// <summary>
        /// Create geometry intent to apply dimensions
        /// </summary>
        public GeometryIntent CreateIntent()
        {
            return _curve._sheet.CreateGeometryIntent(_curve._curve, CreatePoint());
        }

        /// <summary>
        /// Create the geometry intent based on x and y values
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="curve"></param>
        public GeometryPoint(double x, double y, InventorDrawingCurve curve) : base(x, y)
        {
            _curve = curve;
        }

        /// <summary>
        /// Creates the geometry intent based on a source inventor point
        /// </summary>
        /// <param name="point"></param>
        /// <param name="curve"></param>
        public GeometryPoint(Point2d point, InventorDrawingCurve curve) : base(point)
        {
            _curve = curve;
        }
        
        
    }
}