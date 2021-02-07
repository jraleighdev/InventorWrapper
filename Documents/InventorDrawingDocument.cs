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
    /// <summary>
    /// Inventor Drawing documetn
    /// </summary>
    public class InventorDrawingDocument : InventorDocument
    {
        /// <summary>
        /// Reference to the interop drawing document 
        /// </summary>
        private DrawingDocument _drawing;

        /// <summary>
        /// Sheets for the active document
        /// </summary>
        public List<InventorSheet> Sheets { get; set; }

        /// <summary>
        /// Sets up the drawing document and gets the sheets
        /// </summary>
        /// <param name="doc"></param>
        public InventorDrawingDocument(Document doc) : base(doc) 
        {
            _drawing = (DrawingDocument)doc;
            Sheets = new List<InventorSheet>();

            GetSheets();
        }

        /// <summary>
        /// Gets the sheets from the active document
        /// </summary>
        private void GetSheets()
        {
            foreach (Sheet s in _drawing.Sheets)
            {
                Sheets.Add(new InventorSheet(s));
            }
        }

        /// <summary>
        /// Get the selected curve from the active sheet
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Gets all the selected curves
        /// </summary>
        /// <returns></returns>
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
