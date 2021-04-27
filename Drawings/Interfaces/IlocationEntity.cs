using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventorWrapper.Drawings.Curves;

namespace InventorWrapper.Drawings.Interfaces
{
    public interface ILocationEntity : IMajorPoints
    {
        string Name { get; set; }

        double Height { get; }

        double Width { get; }

        Point Position { get; set; }

    }
}
