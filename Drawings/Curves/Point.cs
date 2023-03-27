using Inventor;

namespace InventorWrapper.Drawings.Curves
{
    public class Point
    {
        public double X { get; set; }

        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Point(Point2d point)
        {
            X = point.X;
            Y = point.Y;
        }

        public Point2d CreatePoint()
        {
            return InventorApplication._inventor.TransientGeometry.CreatePoint2d(X, Y);
        }
        
        public static Point MidPoint(Point pointOne, Point pointTwo)
        {
            return new Point((pointOne.X + pointTwo.X) / 2, (pointOne.Y + pointTwo.Y) / 2);
        }
    }
}
