using InventorWrapper.Drawings;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.CaptureDto.DrawingCapture
{
    public class SheetCaptureDto
    {
        public Guid Id { get; set; }

        public Guid DrawingId { get; set; }

        public string Name { get; set; }

        public ObservableCollection<ViewCaptureDto> Views { get; set; }

        public void AddDim(InventorView view)
        {
            var viewCap = new ViewCaptureDto(view);

            viewCap.SheetId = Id;

            Views.Add(viewCap);
        }

        public SheetCaptureDto()
        {
            Views = new ObservableCollection<ViewCaptureDto>();
        }

        public SheetCaptureDto(InventorSheet inventorSheet)
        {
            Views = new ObservableCollection<ViewCaptureDto>();
            Name = inventorSheet.Name;

            Guid.NewGuid();

            foreach (var v in inventorSheet.Views)
            {
                Views.Add(new ViewCaptureDto(v));
            }
        }
    }
}
