using System.Runtime.InteropServices;
using Inventor;
using InventorWrapper.Drawings.DrawingSheet.Style;

namespace InventorWrapper.Drawings.Annotations
{
    public class InventorGeneralNote : InventorDrawingNote
    {
        public GeneralNote _generalNote;

        private InventorTextStyle _textStyle;
        
        public InventorGeneralNote(GeneralNote note) : base((DrawingNote)note)
        {
            _generalNote = note;
        }

        public double FittedTextHeight => _generalNote.FittedTextHeight;

        public double FittedTextWidth => _generalNote.FittedTextWidth;

        public new double Height
        {
            get => _generalNote.Height;
            set => _generalNote.Height = value;
        }

        public InventorTextStyle TextStyle
        {
            get
            {
                if (_textStyle == null)
                {
                    _textStyle = new InventorTextStyle(_generalNote.TextStyle);
                }

                return _textStyle;
            }
        }
        
        public override void Dispose()
        {
            if (_generalNote != null)
            {
                _textStyle?.Dispose();
                
                Marshal.ReleaseComObject(_generalNote);
                _generalNote = null;
            }
        }
    }
}