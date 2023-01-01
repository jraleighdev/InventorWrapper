using Inventor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Geometry
{
    public class InventorWorkPlanes : List<InventorWorkPlane>, IDisposable
    {
        public InventorWorkPlanes(AssemblyComponentDefinition adef)
        {
            foreach (WorkPlane plane in adef.WorkPlanes)
            {
                Add(new InventorWorkPlane(plane));
            }
        }

        public InventorWorkPlanes(PartComponentDefinition pdef)
        {
            foreach (WorkPlane plane in pdef.WorkPlanes)
            {
                Add(new InventorWorkPlane(plane));
            }
        }

        public void Dispose()
        {
            if (Count == 0) return;

            foreach (var plane in this)
            {
                plane.Dispose();
            }

            Clear();
        }
    }

    public class InventorWorkPlane : IDisposable
    {
        public WorkPlane _workPlane;

        public string Name => _workPlane.Name;

        public InventorWorkPlane(WorkPlane workPlane)
        {
            _workPlane = workPlane; 
        }

        public void Dispose()
        {
            if (_workPlane != null)
            {
                Marshal.ReleaseComObject(_workPlane);
                _workPlane = null;
            }
        }
    }
}
