using InventorWrapper.Drawings;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.CaptureDto.DrawingCapture
{
    public class ViewCaptureDto
    {
        public Guid Id { get; set; }

        public Guid SheetId { get; set; }

        public string ReferencedFileName { get; set; }

        public bool Projected { get; set; }

        public string Name { get; set; }

        public double Scale { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        public ObservableCollection<DimensionCaptureDto> Dimensions { get; set; }

        public DimensionCaptureDto AddDim()
        {
            var dim = new DimensionCaptureDto();

            dim.ViewId = Id;

            Dimensions.Add(dim);

            return dim;
        }

        public ViewCaptureDto()
        {
            Dimensions = new ObservableCollection<DimensionCaptureDto>();
        }

        public ViewCaptureDto(InventorView view)
        {
            Dimensions = new ObservableCollection<DimensionCaptureDto>();

            ReferencedFileName = view.Document.FileName;

            Name = view.Name;

            Projected = view._view.ParentView == null;

            Scale = view.Scale;

            X = view.Point.X;

            Y = view.Point.Y;

            Id = Guid.NewGuid();
        }
    }
}
