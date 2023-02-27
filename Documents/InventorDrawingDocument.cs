using Inventor;
using InventorWrapper.Drawings;
using InventorWrapper.Drawings.Curves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventorWrapper.Drawings.Enums;

namespace InventorWrapper.Documents
{
    /// <summary>
    /// Inventor Drawing document
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
        /// Adds new sheet to the drawing with option to add title block
        /// </summary>
        /// <param name="drawingSheetSize">Choose a standard sheet size or a custom one</param>
        /// <param name="addDefaultBoder">Optional parameter to add the default border</param>
        /// <param name="addTitleBlock">Optional parameter to add the title block if true title block name must be set</param>
        /// <param name="titleBlockName">Optional parameter name of the title block to add</param>
        /// <returns></returns>
        public InventorSheet AddSheet(InventorDrawingSheetSizeEnum drawingSheetSize = InventorDrawingSheetSizeEnum.kDefaultDrawingSheetSize, bool addDefaultBorder = true, bool addTitleBlock = false, string titleBlockName = "")
        {
            var sheet = new InventorSheet(_drawing.Sheets.Add((DrawingSheetSizeEnum)drawingSheetSize));

            if (addDefaultBorder) sheet.AddBorder();

            if (addTitleBlock)
            {
                sheet.AddTitleBlock(titleBlockName);
            }

            return sheet;
        }

        public InventorSheet ActiveSheet => new InventorSheet(_drawing.ActiveSheet);

    }
}
