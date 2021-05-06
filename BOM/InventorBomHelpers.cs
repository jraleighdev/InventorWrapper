using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventorWrapper.Documents;

namespace InventorWrapper.BOM
{
    public static class InventorBomHelpers
    {
        public static List<InventorBomItem> GetStructuredBill(InventorAssemblyDocument adoc)
        {
            // store the previous state of the level details
            var previousLevelOfDetail = adoc.RepresentationManager.ActiveLevelOfDetail;

            // Extract bill of materials from the master level detail custom details will cause issues
            adoc.RepresentationManager.ActivateLevelOfDetail("Master");

            adoc.Bom.StructuredViewEnabled = true;
            adoc.Bom.StructureViewFirstLevelOnly = false;
            adoc.Bom.View = "Structured";
            
            var bomItems = adoc.Bom.GetBill();

            // Set the previous detail back after finishing
            adoc.RepresentationManager.ActivateLevelOfDetail(previousLevelOfDetail);

            return bomItems;
        }

        public static List<InventorBomItem> GetFlatBill(InventorAssemblyDocument adoc)
        {
            // store the previous state of the level details
            var previousLevelOfDetail = adoc.RepresentationManager.ActiveLevelOfDetail;

            // Extract bill of materials from the master level detail custom details will cause issues
            adoc.RepresentationManager.ActivateLevelOfDetail("Master");

            adoc.Bom.PartsOnlyViewEnabled = true;
            adoc.Bom.View = "Parts Only";

            var bomItems = adoc.Bom.GetBill();

            // Set the previous detail back after finishing
            adoc.RepresentationManager.ActivateLevelOfDetail(previousLevelOfDetail);

            return bomItems;
        }
    }
}
