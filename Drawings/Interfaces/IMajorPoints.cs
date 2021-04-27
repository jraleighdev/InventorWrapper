using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventorWrapper.Drawings.Curves;

namespace InventorWrapper.Drawings.Interfaces
{
    public interface IMajorPoints
    {
        Point TopLeftPoint { get; }

        Point TopRightPoint { get; }

        Point BottomLeftPoint { get; }

        Point BottomRightPoint { get; }

        Point CenterPoint { get; }
    }
}
