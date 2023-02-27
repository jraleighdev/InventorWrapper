using Inventor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventorWrapper.Drawings.Enums;

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
        public string Title { get; set; }

        public List<InventorTableColumnDto> Columns { get; private set; }

        public int ColumnQty => Columns.Count;

        public int RowQty { get; private set; }

        /// <summary>
        /// Provide inventor table column dto and number of rows
        /// </summary>
        /// <param name="columns">Column row qty cannot be greater the provided row qty</param>
        /// <param name="rowQty">Total number of rows for the table</param>
        /// <param name="defaultValue">If row data isn't provided for one then a default value will be added</param>
        public InventorTableDto(string title, List<InventorTableColumnDto> columns, int rowQty, string defaultValue = "-")
        {
            Title = title;

            Columns = columns;

            RowQty = rowQty;

            foreach (var column in columns)
            {
                if (column.RowData.Count > rowQty)
                {
                    throw new Exception("Column row data cannot be greater than row qty");
                }

                if (column.RowData.Count < rowQty)
                {
                    var numberOfRowsToAdd = rowQty - column.RowData.Count;

                    for (var i = column.RowData.Count; i < numberOfRowsToAdd; i++)
                    {
                        column.RowData.Add(defaultValue);
                    }
                }
            }
        }
    }

    public class InventorTableColumnDto
    {
        public InventorTableColumnDto(string title, List<string> rowData)
        {
            Title = title;
            RowData = rowData;
        }

        public InventorTableColumnDto()
        {
            RowData = new List<string>();
        }
        
        public string Title { get; set; }

        /// <summary>
        /// Defaults to 1/2 an centimeter
        /// </summary>
        public double Width { get; set; } = 0.5;

        public InventorHeaderPlacementEnum HeaderPlacement { get; set; } = InventorHeaderPlacementEnum.HeadingAtTop;

        public InventorHorizontalTextAlignment HeaderTextAlignment { get; set; } =
            InventorHorizontalTextAlignment.AlignTextCenter;

        public InventorHorizontalTextAlignment DataTextAlignment { get; set; } =
            InventorHorizontalTextAlignment.AlignTextCenter;

        public List<string> RowData { get; set; }
    }
}
