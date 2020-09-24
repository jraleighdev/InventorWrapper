using Inventor;
using InventorWrapper.Drawings;
using InventorWrapper.Drawings.Curves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Documents
{
    public class InventorDrawingDocument : InventorDocument
    {
        private DrawingDocument _drawing;

        public List<InventorSheet> Sheets { get; set; }

        public InventorDrawingDocument(Document doc) : base(doc) 
        {
            _drawing = (DrawingDocument)doc;
            Sheets = new List<InventorSheet>();

            GetSheets();
        }

        private void GetSheets()
        {
            foreach (Sheet s in _drawing.Sheets)
            {
                Sheets.Add(new InventorSheet(s));
            }
        }

        public InventorDrawingCurve SelectedCurve()
        {
            if (SelectedItem() is DrawingCurveSegment drawingCurveSegment)
            {
                return new InventorDrawingCurve(drawingCurveSegment);
            }
            else if (SelectedItem() is DrawingCurve drawingCurve)
            {
                return new InventorDrawingCurve(drawingCurve);
            }

            return null;
        }

        public List<InventorDrawingCurve> SelectedCurves()
        {
            var seletedItems = SelectedItems();

            var tempList = new List<InventorDrawingCurve>();

            foreach (var s in seletedItems)
            {
                if (s is DrawingCurveSegment drawingCurveSegment)
                {
                    tempList.Add(new InventorDrawingCurve(drawingCurveSegment));
                }
                else if (s is DrawingCurve drawingCurve)
                {
                    tempList.Add(new InventorDrawingCurve(drawingCurve));
                }
            }

            return tempList;
        }
    }
}
