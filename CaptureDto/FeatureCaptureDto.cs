using InventorWrapper.CaptureDto.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.CaptureDto
{
    public class FeatureCaptureDto
    {
        public object FeatureSource { get; set; }

        public string Name { get; set; }

        public FeatureCaptureType Type { get; set; }

        public bool Suppressed { get; set; }

        public FeatureCaptureDto(object feature, string name, FeatureCaptureType type, bool suppressed)
        {
            FeatureSource = feature;
            Name = name;
            Type = type;
            Suppressed = suppressed;
        }
    }
}
