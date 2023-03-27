using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Inventor;
using InventorWrapper.Drawings.Curves;
using InventorWrapper.Enums;

namespace InventorWrapper.Drawings.Annotations
{
    public class InventorLeader : IDisposable
    {
        public Leader _leader;

        public InventorLeader(Leader leader)
        {
            _leader = leader;
        }

        public void AddLeader(List<Curves.Point> points)
        {
            var objCollection = InventorApplication.CreateObjectCollection();

            foreach (var point in points)
            {
                objCollection.Add(point);
            }
            
            _leader.AddLeader(objCollection);

            Marshal.ReleaseComObject(objCollection);
        }

        public InventorObjectTypes Type => (InventorObjectTypes)_leader.Type;
        
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}