using System.Runtime.InteropServices;
using Inventor;

namespace InventorWrapper.Drawings.Dimensions.OrdinateDims
{
    public class InventorOrdinateDimension : IDimension
    {
        private OrdinateDimension _dimension;
        
        /// <summary>
        /// Reference to the parent sheet
        /// </summary>
        public InventorSheet Sheet { get; private set; }

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

        public InventorOrdinateDimension(OrdinateDimension dimension)
        {
            _dimension = dimension;
            Sheet = new InventorSheet(_dimension.Parent);
        }
        
        public bool IsOrdinateSetMember => _dimension.IsOrdinateSetMember;
        
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