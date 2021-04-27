using Inventor;
using Point = InventorWrapper.Drawings.Curves.Point;

namespace InventorWrapper.Drawings.Dimensions.OrdinateDims
{
    public class InventorDiameterGeneralDimension : InventorGeneralDimension
    {
        private readonly DiameterGeneralDimension _dimension;

        public InventorDiameterGeneralDimension(DiameterGeneralDimension dimension) : base((GeneralDimension)dimension)
        {
            _dimension = dimension;
        }

        public Point Intent => new Point(_dimension.Intent.PointOnSheet);
    }
}