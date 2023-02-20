using InventorWrapper.Drawings.Curves;
using InventorWrapper.Drawings.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public static List<InventorDrawingCurve> GetCircularCurves(this IEnumerable<InventorDrawingCurve> curves)
        {
            return FilterByType(curves, CurveTypes.CircleCurve);
        }


    }
}
