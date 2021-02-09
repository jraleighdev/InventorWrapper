using Inventor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Features
{
    /// <summary>
    /// Manages the status of the features
    /// </summary>
    public class InventorFeature : IDisposable
    {
        public PartFeature _feature;

        /// <summary>
        /// Get the name of the feature
        /// </summary>
        public string Name => _feature.Name;

        /// <summary>
        /// Sets the status of the feature
        /// </summary>
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
