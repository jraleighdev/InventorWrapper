using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.IProps
{
    public enum IpropertyEnum
    {
        [Description("Description")]
        [Category("Design Tracking Properties")]
        Description,

        [Description("Part Number")]
        [Category("Design Tracking Properties")]
        PartNumber,

        [Description("Stock Number")]
        [Category("Design Tracking Properties")]
        StockNumber,

        [Description("Cost Center")]
        [Category("Design Tracking Properties")]
        CostCenter,

        [Description("Custom")]
        [Category("Inventor User Defined Properties")]
        Custom
    }
}


//Inventor Document Summary Information
//Inventor Summary Information
//Design Tracking Properties
//Inventor User Defined Properties