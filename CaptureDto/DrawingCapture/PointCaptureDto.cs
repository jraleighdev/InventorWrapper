using InventorWrapper.CaptureDto.DrawingCapture.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.CaptureDto.DrawingCapture
{
    public class PointCaptureDto
    {
        public Guid Id { get; set; }

        public Guid DimensionId { get; set; }

        public string Name { get; set; }

        public string OccurencePath { get; set; }

        /// <summary>
        /// If the we should capture a single point or all the matching points
        /// </summary>
        public PointCaptureType CaptureType { get; set; }

        public PointLocationEnum PointLocation { get; set; }

        public PointCaptureDto()
        {
            Name = "Enter Name";
            Id = Guid.NewGuid();
        }
    }
}
