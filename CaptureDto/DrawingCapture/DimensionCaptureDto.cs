using InventorWrapper.CaptureDto.DrawingCapture.Enums;
using InventorWrapper.Drawings;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.CaptureDto.DrawingCapture
{
    public class DimensionCaptureDto
    {
        public Guid Id { get; set; }

        public Guid ViewId { get; set; }

        public string Name { get; set; }

        public ObservableCollection<PointCaptureDto> Points { get; set; }

        public DimensionTypeEnum Type { get; set; }

        public DimensionDirectionEnum Direction { get; set; }

        public PointCaptureDto AddPoint()
        {
            var p = new PointCaptureDto();

            p.DimensionId = Id;

            Points.Add(p);

            return p;
        }

        public DimensionCaptureDto()
        {
            Name = "Enter Name";

            Id = Guid.NewGuid();

            Points = new ObservableCollection<PointCaptureDto>();
        }
    }
}
