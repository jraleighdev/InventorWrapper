using System;
using System.Runtime.InteropServices;
using Inventor;
using InventorWrapper.Drawings.DrawingSheet.Style;
using InventorWrapper.Drawings.Enums;
using InventorWrapper.Enums;
using Point = InventorWrapper.Drawings.Curves.Point;

namespace InventorWrapper.Drawings
{
    public class InventorDrawingViewLabel : IDisposable
    {
        public DrawingViewLabel _label;

        private InventorColor _color;
        
        public InventorDrawingViewLabel(DrawingViewLabel label)
        {
            _label = label;
        }
        
        public InventorColor Color
        {
            get
            {
                if (_color == null )
                {
                    _color = new InventorColor(_label.Color);
                }

                return _color;
            }
        }

        public bool ConstrainToBorder
        {
            get => _label.ConstrainToBorder;
            set => _label.ConstrainToBorder = value;
        }

        public InventorHorizontalTextAlignment HorizontalJustification
        {
            get => (InventorHorizontalTextAlignment)_label.HorizontalJustification;
            set => _label.HorizontalJustification = (HorizontalTextAlignmentEnum)value;
        }

        public double LineSpacing
        {
            get => _label.LineSpacing;
            set => _label.LineSpacing = value;
        }

        public InventorLineSpacingEnum LineSpacingType
        {
            get => (InventorLineSpacingEnum)_label.LineSpacingType;
            set => _label.LineSpacingType = (TextLineSpacingTypeEnum)value;
        }

        public Curves.Point Position
        {
            get => new Point(_label.Position);
            set => _label.Position = value.CreatePoint();
        }

        public InventorVerticalTextAlignmentEnum StackedTextPosition
        {
            get => (InventorVerticalTextAlignmentEnum)_label.StackedTextPosition;
            set => _label.StackedTextPosition = (VerticalTextAlignmentEnum)value;
        }

        public string Text => _label.Text;

        public InventorVerticalTextAlignmentEnum VerticalJustification
        {
            get => (InventorVerticalTextAlignmentEnum)_label.VerticalJustification;
            set => _label.VerticalJustification = (VerticalTextAlignmentEnum)value;
        }

        public InventorObjectTypes Type => (InventorObjectTypes)_label.Type;
        
        public void Dispose()
        {
            if (_label != null)
            {
                Marshal.ReleaseComObject(_label);
            }
        }
    }
}