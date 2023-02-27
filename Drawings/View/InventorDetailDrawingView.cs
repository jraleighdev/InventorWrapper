using Inventor;

namespace InventorWrapper.Drawings
{
    public class InventorDetailDrawingView : InventorView
    {
        public DetailDrawingView _detailDrawing;
        
        public InventorDetailDrawingView(DetailDrawingView view, InventorSheet parent) : base((DrawingView)view, parent)
        {
            _detailDrawing = view;
        }
    }
}