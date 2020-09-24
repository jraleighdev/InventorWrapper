using Inventor;
using InventorWrapper.Documents;
using InventorWrapper.Drawings;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.CaptureDto.DrawingCapture
{
    public class DrawingCaptureDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string FileName { get; set; }

        public void AddSheet(InventorSheet inventorSheet)
        {
            var newSheet = new SheetCaptureDto(inventorSheet);

            newSheet.DrawingId = Id;

            Sheets.Add(newSheet);
        }

        public ObservableCollection<SheetCaptureDto> Sheets { get; set; }

        public DrawingCaptureDto()
        {
            Sheets = new ObservableCollection<SheetCaptureDto>();
        }

        public DrawingCaptureDto(InventorDrawingDocument inventorDrawing)
        {
            Sheets = new ObservableCollection<SheetCaptureDto>();

            Id = Guid.NewGuid();

            Name = inventorDrawing.Name;
            FileName = inventorDrawing.FileName;

            foreach (var s in inventorDrawing.Sheets)
            {
                Sheets.Add(new SheetCaptureDto(s));
            }
        }
    }
}
