using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Drawings.Helpers.DTO
{
    /// <summary>
    /// Object structure to build inventor tables.
    /// Inventor tables are built of three arrays.
    /// titles
    /// contents
    /// width
    /// Goals is make a standard dto to elimate process
    /// </summary>
    public class InventorTableDto
    {
    }

    public class InventorTableColumnDto
    {
        public string Title { get; set; }
    }
}
