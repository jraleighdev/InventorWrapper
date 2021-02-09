namespace InventorWrapper.CopyTools
{
    /// <summary>
    /// Data for tracking references
    /// </summary>
    public class ReferenceDto
    {
        /// <summary>
        /// Original file path 
        /// </summary>
        public string OriginalReference { get; set; }
        
        /// <summary>
        /// New file path
        /// </summary>
        public string NewReference { get; set; }
    }
}