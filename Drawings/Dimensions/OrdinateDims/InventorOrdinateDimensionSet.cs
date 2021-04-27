using System.Collections.Generic;
using Inventor;
using InventorWrapper.Drawings.Curves;

namespace InventorWrapper.Drawings.Dimensions.OrdinateDims
{
    public class InventorOrdinateDimensionSet : List<InventorOrdinateDimension>
    {
        private OrdinateDimensionSet _ordinateDimensionSet;

        public InventorOrdinateDimensionSet(OrdinateDimensionSet ordinateDimensionSet)
        {
            _ordinateDimensionSet = ordinateDimensionSet;
            
            foreach (OrdinateDimension member in _ordinateDimensionSet.Members)
            {
                Add(new InventorOrdinateDimension(member));
            }
        }
        
        public InventorOrdinateDimension AddMember(GeometryPoint point)
        {
            var newMember = new InventorOrdinateDimension(_ordinateDimensionSet.AddMember(point.CreateIntent()));
            
            Add(newMember);

            return newMember;
        }
        
        public void Delete() => _ordinateDimensionSet.Delete();
    }
}