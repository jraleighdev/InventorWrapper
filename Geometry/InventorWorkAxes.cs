using Inventor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Geometry
{
    public class InventorWorkAxes : List<InventorWorkAxis>, IDisposable
    {
        public InventorWorkAxes(AssemblyComponentDefinition adef)
        {
            foreach (WorkAxis axis in adef.WorkAxes)
            {
                Add(new InventorWorkAxis(axis));
            }
        }

        public InventorWorkAxes(PartComponentDefinition pdef)
        {
            foreach (WorkAxis axis in pdef.WorkAxes)
            {
                Add(new InventorWorkAxis(axis));
            }
        }

        public void Dispose()
        {
            if (Count == 0) return;

            foreach (var axis in this)
            {
                axis.Dispose();
            }

            Clear();
        }
    }

    public class InventorWorkAxis : IDisposable
    {
        public WorkAxis _axis;

        public string Name => _axis.Name;

        public InventorWorkAxis(WorkAxis axis)
        {
            _axis = axis;   
        }

        public void Dispose()
        {
            if (_axis != null)
            {
                Marshal.ReleaseComObject(_axis);
                _axis = null;
            }
        }
    }
}
