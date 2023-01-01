using InventorWrapper.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Geometry
{
    public class InventorProxy : IDisposable
    {
        /// <summary>
        /// Inventor interop
        /// </summary>
        public object _reference;

        public FeatureTypes Type;

        public string Name { get; set; }

        public string Value { get; set; }

        public InventorProxy(object reference, FeatureTypes type, string name, string value)
        {
            _reference = reference;
            Type = type;
            Name = name;
            Value = value;
        }

        public void Dispose()
        {
            if (_reference != null )
            {
                Marshal.ReleaseComObject(_reference);
                _reference = null;
            }
        }
    }
}
