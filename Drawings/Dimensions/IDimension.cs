using System;
using System.Runtime.InteropServices;
using Inventor;

namespace InventorWrapper.Drawings.Dimensions
{
    public interface IDimension : IDisposable
    {
        InventorSheet Sheet { get; }
        
        string Text { get; set; }

        double ModelValue { get; }

        bool Attached { get; }
        
        bool HideValue { get; set; }

        void Delete();
    }
}