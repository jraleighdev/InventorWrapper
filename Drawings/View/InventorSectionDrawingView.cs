using Inventor;

namespace InventorWrapper.Drawings
{
    public class InventorSectionDrawingView : InventorView
    {
        public SectionDrawingView _sectionDrawingView;
        
        public InventorSectionDrawingView(SectionDrawingView view, InventorSheet parent) : base((DrawingView)view, parent)
        {
            _sectionDrawingView = view;
        }
    }
}