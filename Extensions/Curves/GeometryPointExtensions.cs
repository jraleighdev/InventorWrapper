using System;
using System.Collections.Generic;
using System.Linq;
using Inventor;
using InventorWrapper.Drawings.Curves;
using InventorWrapper.Drawings.Enums;

namespace InventorWrapper.Extensions.Curves
{
    public static class GeometryPointExtensions
    {
        /// <summary>
        /// Get the max x points for the given curves
        /// </summary>
        /// <returns></returns>
        public static double Tolerance { get; set; } = 0.005;
        
        public static List<GeometryPoint> MaxXPoints(this List<GeometryPoint> points)
        {
            var maxXValue = points.Max(point => point.X);

            return points.Where(point => Math.Abs(point.X - maxXValue) < Tolerance).ToList();
        }
        
        /// <summary>
        /// Get the min x points for the given curves
        /// </summary>
        /// <returns></returns>
        public static List<GeometryPoint> MinXPoints(this List<GeometryPoint> points)
        {
            var minXValue = points.Min(point => point.X);

            return points.Where(point => Math.Abs(point.X - minXValue) < Tolerance).ToList();
        }
        
        /// <summary>
        /// Get the max y points for the given curves
        /// </summary>
        /// <returns></returns>
        public static List<GeometryPoint> MaxYPoints(this List<GeometryPoint> points)
        {
            var maxYValue = points.Max(point => point.Y);

            return points.Where(point => Math.Abs(point.Y - maxYValue) < Tolerance).ToList();
        }
        
        /// <summary>
        /// Get the min y points for the given curves
        /// </summary>
        /// <returns></returns>
        public static List<GeometryPoint> MinYPoints(this List<GeometryPoint> points)
        {
            var minYValue = points.Min(point => point.Y);

            return points.Where(point => Math.Abs(point.Y - minYValue) < Tolerance).ToList();
        }

        /// <summary>
        /// Get the first max x point
        /// </summary>
        /// <returns></returns>
        public static GeometryPoint MaxXPoint(this List<GeometryPoint> points) => points.MaxXPoints().FirstOrDefault();

        /// <summary>
        /// Get the first min x point
        /// </summary>
        /// <returns></returns>
        public static GeometryPoint MinXPoint(this List<GeometryPoint> points) => points.MinXPoints().FirstOrDefault();

        /// <summary>
        /// Get the first Max y point
        /// </summary>
        /// <returns></returns>
        public static GeometryPoint MaxYPoint(this List<GeometryPoint> points) => points.MaxYPoints().FirstOrDefault();

        /// <summary>
        /// Get the first min y point
        /// </summary>
        /// <returns></returns>
        public static GeometryPoint MinYPoint(this List<GeometryPoint> points) => points.MinYPoints().FirstOrDefault();

        /// <summary>
        /// Gets the center points from circular curves in the list
        /// </summary>
        /// <returns></returns>
        public static List<GeometryPoint> CenterPoints(this List<GeometryPoint> points)
        {
            return points.Where(point => point.PointType == PointType.CenterPoint).ToList();
        }
        
        public static GeometryPoint MaxXMaxYPoint(this List<GeometryPoint> points) => 
            points.MaxXPoints().MaxYPoint();
        
        public static GeometryPoint MaxXMinYPoint(this List<GeometryPoint> points) =>
            points.MaxXPoints().MinYPoint();

        public static GeometryPoint MinXMaxYPoint(this List<GeometryPoint> points) =>
            points.MinXPoints().MaxYPoint();

        public static GeometryPoint MinXMinYPoint(this List<GeometryPoint> points) =>
            points.MinXPoints().MinYPoint();

        public static List<GeometryPoint> RemoveDuplicateX(this List<GeometryPoint> points)
        {
            var tempList = new List<GeometryPoint>();

            foreach (var point in points)
            {
                if (tempList.Count == 0)
                {
                    tempList.Add(point);
                }
                else
                {
                    var matchingX = tempList.Any(p => Math.Abs(point.X - p.X) < 0.005);
                    
                    if (!matchingX)
                    {
                        tempList.Add(point);
                    }
                }
            }

            return tempList;
        }
        
        public static List<GeometryPoint> RemoveDuplicateY(this List<GeometryPoint> points)
        {
            var tempList = new List<GeometryPoint>();

            foreach (var point in points)
            {
                if (tempList.Count == 0)
                {
                    tempList.Add(point);
                }
                else
                {
                    var matchingY = tempList.Any(p => Math.Abs(point.Y - p.Y) < 0.005);
                    
                    if (!matchingY)
                    {
                        tempList.Add(point);
                    }
                }
            }

            return tempList;
        }
    }
}