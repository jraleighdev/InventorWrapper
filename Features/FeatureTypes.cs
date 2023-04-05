using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Features
{
    public enum FeatureTypes
    {
        WorkPlane = 0,
        WorkPoint = 1,
        SurfaceBody = 2,
        Face = 3,
        Edge = 4,
    }

    public enum HoleTypes
    {
        CounterBore = 21507,
        CounterSink = 21506,
        Drilled = 21505,
        SpotFace = 21508
    }
}
