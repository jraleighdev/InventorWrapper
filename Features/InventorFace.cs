using Inventor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Features
{
    public class InventorFace : IDisposable
    {
        public Face _face;

        public InventorFace(Face face)
        {
            _face = face;   
        }

        public void Dispose()
        {
            if ( _face != null )
            {
                Marshal.ReleaseComObject(_face);
                _face = null;
            }
        }
    }
}
