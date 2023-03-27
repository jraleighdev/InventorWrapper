using System;
using System.Runtime.InteropServices;
using Inventor;
using InventorWrapper.Drawings.DrawingSheet.Style;
using InventorWrapper.Drawings.Enums;
using InventorWrapper.Enums;

namespace InventorWrapper.Drawings.Annotations
{
    public class InventorDrawingNote : IDisposable
    {
        public DrawingNote _note;

        public InventorDrawingNote(DrawingNote note)
        {
            _note = note;
        }
        
        private InventorColor _color;
        
        public void Delete() => _note.Delete();

        public InventorColor Color
        {
            get
            {
                if (_color == null )
                {
                    _color = new InventorColor(_note.Color);
                }

                return _color;
            }
        }

        public string FormattedText
        {
            get => _note.FormattedText;
            set => _note.FormattedText = value;
        }

        public InventorHorizontalTextAlignment HorizontalJustification
        {
            get => (InventorHorizontalTextAlignment)_note.HorizontalJustification;
            set => _note.HorizontalJustification = (HorizontalTextAlignmentEnum)value;
        }

        public double LineSpacing
        {
            get => _note.LineSpacing;
            set => _note.LineSpacing = value;
        }

        public Curves.Point Position
        {
            get => new Curves.Point(_note.Position);
            set => _note.Position = value.CreatePoint();
        }

        public Curves.Point TopRightPoint => new Curves.Point(_note.RangeBox.MaxPoint);

        public Curves.Point TopLeftPoint => new Curves.Point(_note.RangeBox.MinPoint.X, _note.RangeBox.MaxPoint.Y);

        public Curves.Point BottomLeftPoint => new Curves.Point(_note.RangeBox.MinPoint);

        public Curves.Point BottomRightPoint =>
            new Curves.Point(_note.RangeBox.MaxPoint.X, _note.RangeBox.MinPoint.Y);
        
        public Curves.Point CenterPoint => Curves.Point.MidPoint(TopRightPoint, BottomLeftPoint);

        public double Width => Math.Abs(TopRightPoint.X - TopLeftPoint.X);

        public double Height => Math.Abs(TopRightPoint.Y - BottomRightPoint.Y);
        

        public InventorVerticalTextAlignmentEnum StackedTextPosition
        {
            get => (InventorVerticalTextAlignmentEnum)_note.StackedTextPosition;
            set => _note.StackedTextPosition = (VerticalTextAlignmentEnum)value;
        }

        public string Text
        {
            get => _note.Text;
            set => _note.Text = value;
        }

        public InventorObjectTypes Type => (InventorObjectTypes)_note.Type;
        
        public InventorVerticalTextAlignmentEnum VerticalJustification
        {
            get => (InventorVerticalTextAlignmentEnum)_note.VerticalJustification;
            set => _note.VerticalJustification = (VerticalTextAlignmentEnum)value;
        }

        public double WidthScale
        {
            get => _note.WidthScale;
            set => _note.WidthScale = value;
        }
        
        public virtual void Dispose()
        {
            if (_note != null)
            {
                Marshal.ReleaseComObject(_note);
                _note = null;
            }
        }
    }
}