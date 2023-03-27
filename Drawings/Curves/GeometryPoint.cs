using Inventor;
using InventorWrapper.Drawings.Annotations;
using InventorWrapper.Drawings.Enums;

namespace InventorWrapper.Drawings.Curves
{
    public class GeometryPoint : Point
    {
        public InventorDrawingCurve Curve { get; private set; }

        public InventorCenterLine CenterLine { get; private set; }
       
        public PointType PointType { get; private set; }

        public PointSource PointSource { get; private set; }

        /// <summary>
        /// Create geometry intent to apply dimensions
        /// </summary>
        public GeometryIntent CreateIntent()
        {
            switch (PointSource)
            {
                case PointSource.Centerline:
                    return CenterLine._sheet.CreateGeometryIntent(CenterLine._centerLine, CreatePoint());
                case PointSource.Curve:
                default:
                    return Curve._sheet.CreateGeometryIntent(Curve._curve, CreatePoint());
            }
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
            PointSource = PointSource.Curve;
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
            PointSource = PointSource.Curve;
        }

        public GeometryPoint(Point2d point, InventorCenterLine centerLine, PointType pointType) : base(point)
        {
            CenterLine = centerLine;
            PointType = pointType;
            PointSource = PointSource.Centerline;
        }

    }

    public enum PointSource
    {
        Curve = 1,
        Centerline = 2
    }
}