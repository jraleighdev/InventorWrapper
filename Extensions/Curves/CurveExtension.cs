using InventorWrapper.Components;
using InventorWrapper.Drawings.Curves;
using InventorWrapper.Drawings.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Extensions.Curves
{
    public static class CurveExtensions
    {
        public static List<InventorDrawingCurve> FilterByType(this IEnumerable<InventorDrawingCurve> curves, CurveTypes curveType)
        {
            return curves.Where(x => x.CurveType == curveType).ToList();
        }

        public static List<InventorDrawingCurve> GetLinearCurves(this IEnumerable<InventorDrawingCurve> curves)
        {
            return curves.Where(x => x.CurveType == CurveTypes.LineCurve || x.CurveType == CurveTypes.LineSegmentCurve || x.CurveType == CurveTypes.PolylineCurve).ToList();
        }

        public static List<InventorDrawingCurve> RemoveCircularCurves(this IEnumerable<InventorDrawingCurve> curves)
        {
            return curves.Where(x =>
                x.CurveType != CurveTypes.CircleCurve || x.CurveType != CurveTypes.CircularArcCurve ||
                x.CurveType != CurveTypes.EllipseFullCurve || x.CurveType != CurveTypes.EllipticalArcCurve).ToList();
        }

        public static List<InventorDrawingCurve> GetCircularCurves(this IEnumerable<InventorDrawingCurve> curves)
        {
            return FilterByType(curves, CurveTypes.CircleCurve);
        }

        public static List<InventorDrawingCurve> RemoveCurvesWithoutComponent(this IEnumerable<InventorDrawingCurve> curves)
        {
            return curves.Where(x => x.Component!= null).ToList();
        }

        /// <summary>
        /// Get the unique components by checking the path list
        /// </summary>
        /// <param name="curves"></param>
        /// <returns></returns>
        public static List<ComponentCurveGroupDto> GroupCurvesByComponent(this IEnumerable<InventorDrawingCurve> curves)
        {
            var tempList = new List<ComponentCurveGroupDto>();

            var filteredCurves = curves.RemoveCurvesWithoutComponent();

            foreach (var curve in filteredCurves)
            {
                if (tempList.Count == 0)
                {
                    var dto = new ComponentCurveGroupDto(curve.Component);

                    dto.Curves.Add(curve);

                    tempList.Add(dto);

                    continue;
                }

                var match = tempList.FirstOrDefault(x => x.Component.PathList == curve.Component.PathList);

                if (match != null)
                {
                    match.Curves.Add(curve);
                }
                else
                {
                    var dto = new ComponentCurveGroupDto(curve.Component);

                    dto.Curves.Add(curve);

                    tempList.Add(dto);
                }
            }
            
            return tempList;
        }

    }

    public class ComponentCurveGroupDto
    {
        public InventorComponent Component { get; set; }

        public List<InventorDrawingCurve> Curves { get; set; }

        public ComponentCurveGroupDto(InventorComponent component)
        {
            Component = component;
            Curves = new List<InventorDrawingCurve>();
        }
    }
}
