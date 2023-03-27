using Inventor;
using InventorWrapper.Drawings.Curves;
using InventorWrapper.Drawings.Enums;
using InventorWrapper.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Drawings.Annotations
{
    public class InventorCenterLine : IDisposable
    {
        public Centerline _centerLine;

        public Sheet _sheet;

        public InventorCenterLine(Centerline centerLine, Sheet sheet)
        {
            _centerLine = centerLine;
            _sheet = sheet;
        }

        public bool Attached => _centerLine.Attached;

        public List<GeometryPoint> Points => new List<GeometryPoint> { StartPoint, EndPoint };

        public InventorCenterLineType CenterLineType => (InventorCenterLineType)_centerLine.CenterlineType;

        public GeometryPoint EndPoint
        {
            get => new GeometryPoint(_centerLine.EndPoint, this, PointType.EndPoint);
            set => _centerLine.EndPoint = value.CreatePoint();
        }

        public void SetEndPoint(double x, double y)
        {
            _centerLine.EndPoint = new Curves.Point(x, y).CreatePoint();
        }
        
        public CurveTypes GeometryType => (CurveTypes)_centerLine.GeometryType;

        public GeometryPoint StartPoint
        {
            get => new GeometryPoint(_centerLine.StartPoint, this, PointType.EndPoint);
            set => _centerLine.StartPoint = value.CreatePoint();
        }

        public void SetStartPoint(double x, double y)
        {
            _centerLine.StartPoint = new Curves.Point(x, y).CreatePoint();
        }

        public InventorObjectTypes Type => (InventorObjectTypes)_centerLine.Type;

        public bool Visible
        {
            get => _centerLine.Visible;
            set => _centerLine.Visible = value;
        }

        public void Delete() => _centerLine.Delete();
        

        public void Dispose()
        {
            if (_centerLine != null)
            {
                Marshal.ReleaseComObject(_centerLine);
                _centerLine = null;
            }
        }
    }
}
