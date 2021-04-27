using System.Runtime.InteropServices;
using Inventor;

namespace InventorWrapper.Drawings.Dimensions
{
    /// <summary>
    /// Base for all General Dimensions
    /// </summary>
    public class InventorGeneralDimension : IDimension
    {
        private GeneralDimension _dimension;
     
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

        public InventorGeneralDimension(GeneralDimension dimension)
        {
            _dimension = dimension;
            Sheet = new InventorSheet(dimension.Parent);
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