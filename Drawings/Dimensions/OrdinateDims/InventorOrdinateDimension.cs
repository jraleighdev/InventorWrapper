namespace InventorWrapper.Drawings.Dimensions.OrdinateDimensions
{
    public class InventorOrdinateDimension : IDimension
    {
        public InventorSheet Sheet { get; }
        public string Text { get; set; }
        public double ModelValue { get; }
        public bool Attached { get; }
        public bool HideValue { get; set; }

        public InventorOrdinateDimension(OrdinateDimension )
        {
                
        }
        
        public void Delete()
        {
            throw new System.NotImplementedException();
        }
        
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

    }
}