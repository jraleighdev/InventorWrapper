using Inventor;
using InventorWrapper.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Drawings.Curves
{
    public class InventorDrawingCurve
    {
        public DrawingCurve _curve;

        private bool found;

        public string OccurenceName { get; set; }

        public string PathString { get; set; }

        public List<string> OccurencePath { get; set; }

        public InventorDrawingCurve(DrawingCurveSegment curveSegment)
        {
            _curve = curveSegment.Parent;

            FindOccurence(_curve.ModelGeometry);
        }

        public InventorDrawingCurve(DrawingCurve curve)
        {
            _curve = curve;

            FindOccurence(_curve);
        }

        private void FindOccurence(dynamic value)
        {
            if (found) return;

            if (value == null) return;

            if (value is ComponentOccurrence occurrence)
            {
                OccurenceName = occurrence.Name;
                OccurencePath = occurrence.GetOccurencePath();
                PathString = occurrence.GetOccurencePathString();
                found = true;
                return;
            }

            while (!found)
            {
                FindOccurence(value?.Parent);
            }
        }



    }
}
