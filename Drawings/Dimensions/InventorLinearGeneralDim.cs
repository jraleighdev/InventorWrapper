using System.Runtime.InteropServices;
using Inventor;
using InventorWrapper.Drawings.Curves;
using Point = InventorWrapper.Drawings.Curves.Point;

namespace InventorWrapper.Drawings.Dimensions
{
    public class InventorLinearGeneralDim : IDimension
    {
        private LinearGeneralDimension _dimension;
        
        // <summary>
        /// Reference to the parent sheet
        /// </summary>
        public InventorSheet Sheet { get; private set; }

        public InventorLinearGeneralDim(LinearGeneralDimension dimension)
        {
            _dimension = dimension;
            Sheet = new InventorSheet(_dimension.Parent);
        }

        public void CenterText() => _dimension.CenterText();

        public Point PointOne => new Point(_dimension.IntentOne.PointOnSheet);

        public Point PointTwo => new Point(_dimension.IntentTwo.PointOnSheet);

        /// <summary>
        /// Gets and sets the dimension text
        /// </summary>
        public string Text
        {
            get => _dimension.Text.Text;
            set => _dimension.Text.FormattedText = value;
        }

        /// <summary>
        /// Gets the model value
        /// </summary>
        public double ModelValue => _dimension.ModelValue;
        
        /// <summary>
        /// If the dimension is attached
        /// </summary>
        public bool Attached => _dimension.Attached;
        
        /// <summary>
        /// Show and hide the model value
        /// </summary>
        public bool HideValue
        {
            get => _dimension.HideValue;
            set => _dimension.HideValue = value;
        }
        
        public void Delete() => _dimension.Delete();
        
        public void Dispose()
        {
            if (_dimension != null)
            {
                Marshal.ReleaseComObject(_dimension);
                _dimension = null;
            }
        }
    }
}