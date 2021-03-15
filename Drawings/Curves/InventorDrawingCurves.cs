using Inventor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using InventorWrapper.Drawings.Enums;

namespace InventorWrapper.Drawings.Curves
{
    /// <summary>
    /// Collection of inventor drawing curves
    /// </summary>
    public class InventorDrawingCurves : List<InventorDrawingCurve>, IDisposable
    {
        /// <summary>
        /// Source Inventor Interop for drawing curves
        /// </summary>
        private DrawingCurvesEnumerator _curves;
        
        /// <summary>
        /// Reference to the inventor sheet
        /// </summary>
        private readonly Sheet _sheet;
        
        /// <summary>
        /// Cached points reference
        /// </summary>
        private List<GeometryPoint> _points;
        
        public InventorDrawingCurves(DrawingCurvesEnumerator curves, Sheet sheet)
        {
            _curves = curves;
            _sheet = sheet;
            GetCurves();
        }

        /// <summary>
        /// Get the points for the selected curves
        /// </summary>
        public List<GeometryPoint> Points
        {
            get
            {
                if (_points == null || _points.Count == 0)
                {
                    _points = new List<GeometryPoint>();

                    foreach (var curve in this)
                    {
                        foreach (var point in curve.Points())
                        {
                            if (point == null) continue;
                            
                            _points.Add(point);
                        }
                    }
                }
                
                return _points;
            }
        }

        /// <summary>
        /// Get the curves by the given type
        /// </summary>
        /// <returns></returns>
        public List<InventorDrawingCurve> GetCurvesByType(CurveTypes curveType)
        {
            return this.Where(curve => curve.CurveType == curveType).ToList();
        }

        /// <summary>
        /// Gets the circular curve
        /// </summary>
        /// <returns></returns>
        public List<InventorDrawingCurve> GetCircularCurves()
        {
            return GetCurvesByType(CurveTypes.CircleCurve);
        }
        
        /// <summary>
        /// Get the curves from the source inventor collection
        /// </summary>
        private void GetCurves()
        {
            foreach (DrawingCurve curve in _curves)
            {
                this.Add(new InventorDrawingCurve(curve, _sheet));
            }
        }

        public void Dispose()
        {
            if (_curves != null)
            {
                Marshal.ReleaseComObject(_curves);
                _curves = null;
            }
        }
    }
}
