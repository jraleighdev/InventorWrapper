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
    public class InventorTextStyle : IDisposable
    {
        public TextStyle _textStyle;

        private InventorColor _color;

        public InventorTextStyle(TextStyle textStyle)
        {
            _textStyle = textStyle;
        }

        public bool Bold
        {
            get => _textStyle.Bold;
            set => _textStyle.Bold = value;
        }

        public string Comments
        {
            get => _textStyle.Comments;
            set => _textStyle.Comments = value;
        }

        public string Font
        {
            get => _textStyle.Font;
            set => _textStyle.Font = value;
        }

        public double FontSize
        {
            get => _textStyle.FontSize;
            set => _textStyle.FontSize = value;
        }

        public InventorHorizontalTextAlignment HorizontalJustification
        {
            get => (InventorHorizontalTextAlignment)_textStyle.HorizontalJustification;
            set => _textStyle.HorizontalJustification = (HorizontalTextAlignmentEnum)value;
        }

        public bool InUse => _textStyle.InUse;

        public bool Italic
        {
            get => _textStyle.Italic; 
            set => _textStyle.Italic = value;
        }

        public double LineSpacingEnum
        {
            get => _textStyle.LineSpacing;
            set => _textStyle.LineSpacing = value;
        }

        public InventorTextLineSpacingTypeEnum LineSpacingType
        {
            get => (InventorTextLineSpacingTypeEnum)_textStyle.LineSpacingType;
            set => _textStyle.LineSpacingType = (TextLineSpacingTypeEnum)value;
        }

        public string Name
        {
            get => _textStyle.Name;
            set => _textStyle.Name = value;
        }

        /// <summary>
        /// Returned in radians
        /// Can only be set in 90 degree increments
        /// 0, pi/2, pi, 1.5pi
        /// </summary>
        public double Rotation
        {
            get => _textStyle.Rotation;
            set => _textStyle.Rotation = value;
        }

        public InventorStyleTypeEnum StyleType => (InventorStyleTypeEnum)_textStyle.StyleType;

        public InventorObjectTypes Type => (InventorObjectTypes)_textStyle.Type;

        public bool UpToDate => _textStyle.UpToDate;

        public InventorVerticalTextAlignmentEnum VerticalJustification
        {
            get => (InventorVerticalTextAlignmentEnum)_textStyle.VerticalJustification;
            set => _textStyle.VerticalJustification = (VerticalTextAlignmentEnum)value;
        }

        public double WidthScale
        {
            get => _textStyle.WidthScale;
            set => _textStyle.WidthScale = value;
        }

        public InventorColor Color
        {
            get
            {
                if (_color == null )
                {
                    _color = new InventorColor(_textStyle.Color);
                }

                return _color;
            }
        }

        public void Dispose()
        {
            _color?.Dispose();

            if (_textStyle != null )
            {
                Marshal.ReleaseComObject(_textStyle);
                _textStyle = null;
            }
        }
    }
}
