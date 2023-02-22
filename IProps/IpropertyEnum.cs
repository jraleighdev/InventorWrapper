using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.IProps
{
    public class IpropertyStrings
    {
        public const string DesignTrackingProperties = "Design Tracking Properties";

        public const string SummaryInformation = "Summary Information";

        public const string DocumentSummaryInformation = "Document Summary Information";
    }

    /// <summary>
    /// Maps location of inventor properties
    /// Description attribute is the name of the property in inventor
    /// Category refers to the tab
    /// </summary>
    public enum IpropertyEnum
    {
        [Description("Description")]
        [Category(IpropertyStrings.DesignTrackingProperties)]
        Description,

        [Description("Revision Number")]
        [Category(IpropertyStrings.DesignTrackingProperties)]
        RevisionNumber,

        [Description("Project")]
        [Category(IpropertyStrings.DesignTrackingProperties)]
        Project,

        [Description("Designer")]
        [Category(IpropertyStrings.DesignTrackingProperties)]
        Desinger,

        [Description("Engineer")]
        [Category(IpropertyStrings.DesignTrackingProperties)]
        Engineer,

        [Description("Authority")]
        [Category(IpropertyStrings.DesignTrackingProperties)]
        Authority,

        [Description("Estimated Cost")]
        [Category(IpropertyStrings.DesignTrackingProperties)]
        EstimatedCost,

        [Description("Creation Date")]
        [Category(IpropertyStrings.DesignTrackingProperties)]
        CreationDate,

        [Description("Vendor")]
        [Category(IpropertyStrings.DesignTrackingProperties)]
        Vendor,

        [Description("Part Number")]
        [Category(IpropertyStrings.DesignTrackingProperties)]
        PartNumber,

        [Description("Stock Number")]
        [Category(IpropertyStrings.DesignTrackingProperties)]
        StockNumber,

        [Description("Cost Center")]
        [Category(IpropertyStrings.DesignTrackingProperties)]
        CostCenter,

        [Description("Custom")]
        [Category("Inventor User Defined Properties")]
        Custom,

        [Description("Title")]
        [Category(IpropertyStrings.SummaryInformation)]
        Title,

        [Description("Subject")]
        [Category(IpropertyStrings.SummaryInformation)]
        Subject,

        [Description("Author")]
        [Category(IpropertyStrings.SummaryInformation)]
        Author,

        [Description("Manager")]
        [Category(IpropertyStrings.SummaryInformation)]
        Manager,

        [Description("Company")]
        [Category(IpropertyStrings.SummaryInformation)]
        Company,

        [Description("Category")]
        [Category(IpropertyStrings.SummaryInformation)]
        Category,

        [Description("Keywords")]
        [Category(IpropertyStrings.SummaryInformation)]
        Keywords,

        [Description("Comments")]
        [Category(IpropertyStrings.SummaryInformation)]
        Comments,
    }
}

//Inventor Document Summary Information
//Inventor Summary Information
//Design Tracking Properties
//Inventor User Defined Properties