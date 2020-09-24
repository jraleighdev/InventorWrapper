using Inventor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Features
{
    public class InventorFeature : IDisposable
    {
        public PartFeature _feature;

        public string Name => _feature.Name;

        public bool Suppressed
        {
            get => _feature.Suppressed;
            set => _feature.Suppressed = value;
        }


        public InventorFeature(PartFeature feature)
        {
            _feature = feature;
        }

        public void Dispose()
        {
            if (_feature != null)
            {
                Marshal.ReleaseComObject(_feature);
            }
        }
    }
}
