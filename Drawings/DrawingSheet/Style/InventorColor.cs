using Inventor;
using InventorWrapper.Drawings.Enums;
using InventorWrapper.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Drawings.DrawingSheet.Style
{
    public class InventorColor : IDisposable
    {
        public Color _color;

        public InventorColor(Color color)
        {
            _color = color;
        }

        public byte Blue
        {
            get => _color.Blue;
            set => _color.Blue = value;
        }

        public byte Green
        {
            get => _color.Green;
            set => _color.Green = value;
        }

        public byte Red
        {
            get => _color.Red; 
            set => _color.Red = value;
        }

        public double Opacity
        {
            get => _color.Opacity;
            set => _color.Opacity = value;
        }

        public InventorColorSourceTypeEnun ColorSourceType
        {
            get => (InventorColorSourceTypeEnun)_color.ColorSourceType;
            set => _color.ColorSourceType = (ColorSourceTypeEnum)value;
        }

        public InventorObjectTypes Type => (InventorObjectTypes)_color.Type;

        public ColorStruct GetColor()
        {
            _color.GetColor(out byte red, out byte green, out byte blue);

            return new ColorStruct(red, green, blue);
        }

        public void SetColor(byte red, byte green, byte blue)
        {
            _color.SetColor(red, green, blue);
        }

        public void Dispose()
        {
            if ( _color != null )
            {
                Marshal.ReleaseComObject(_color);
                _color = null;
            }
        }
    }

    public struct ColorStruct
    {
        public ColorStruct(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public byte Red { get; set; }

        public byte Green { get; set; }
           
        public byte Blue { get; set; }
    }
}
