using Inventor;
using InventorWrapper.Drawings.Enums;
using InventorWrapper.Enums;
using InventorWrapper.IProps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Drawings.DrawingSheet
{
    public class InventorPartsList : IDisposable
    {
        public PartsList _partsList;

        public InventorSheet Parent { get; private set; }

        public InventorPartsList(PartsList partsList, InventorSheet parent)
        {
            _partsList = partsList;
            Parent = parent;
        }

        public InventorPartsListLevelEnum Level
        {
            get => (InventorPartsListLevelEnum)_partsList.Level;
        }

        public Curves.Point BottomLeft => new Curves.Point(_partsList.RangeBox.MinPoint);

        public Curves.Point BottomRight => new Curves.Point(_partsList.RangeBox.MaxPoint.X, _partsList.RangeBox.MinPoint.Y);

        public Curves.Point TopRight => new Curves.Point(_partsList.RangeBox.MaxPoint);

        public Curves.Point TopLeft => new Curves.Point(_partsList.RangeBox.MinPoint.X, _partsList.RangeBox.MaxPoint.Y);

        public double Height => Math.Abs(TopLeft.Y - BottomLeft.Y);

        public double Width => Math.Abs(BottomRight.X - BottomLeft.X);

        /// <summary>
        /// Adds column to the parts list
        /// TODO file properties need to be implemented
        /// </summary>
        /// <param name="propType"></param>
        /// <param name="iproperty"></param>
        /// <param name="target"></param>
        /// <param name="insertBefore"></param>
        /// <param name="customPropertyName"></param>
        /// <param name="width"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public InventorPartsListColumn AddColumn(InventorPropertyTypeEnum propType, IpropertyEnum iproperty, int target, bool insertBefore, string customPropertyName = "", double width = .5, int index = 0)
        {
            if (target > ColumnsCount)
            {
                throw new Exception($"target ${target} cannnot be greater than {ColumnsCount}");
            }

            PartsListColumn col = null;

            if (propType == InventorPropertyTypeEnum.FileProperty)
            {
                // TODO look up making method to retreive internal property names
            }
            else if (propType == InventorPropertyTypeEnum.CustomProperty)
            {
                if (!Columns.Any(x => x.Title == customPropertyName))
                {
                    try
                    {
                        col = _partsList.PartsListColumns.Add((PropertyTypeEnum)propType, "", customPropertyName, target, insertBefore);
                    }
                    catch (Exception ex)
                    {
                        Parent.Errors.Add(ex);
                    }
                }
            }
            else
            {
                try
                {
                    col = _partsList.PartsListColumns.Add((PropertyTypeEnum)propType, null, null, target, insertBefore);
                }
                catch (Exception ex)
                {
                    Parent.Errors.Add(ex);
                }
            }

            if (col != null)
            {
                col.Width= width;

                return new InventorPartsListColumn(col);
            }

            return null;
        }

        public List<InventorPartsListColumn> Columns
        {
            get
            {
                var columns = new List<InventorPartsListColumn>();

                if (ColumnsCount > 0)
                {
                    for (var i = 1; i <= ColumnsCount; i++)
                    {
                        columns.Add(new InventorPartsListColumn(_partsList.PartsListColumns[i]));
                    }
                }

                return columns;
            }
        }

        public List<InventorPartsListRow> Rows
        {
            get
            {
                var rows = new List<InventorPartsListRow>();

                if (RowsCount > 0)
                {
                    for (var i = 1; i <= ColumnsCount; i++)
                    {
                        rows.Add(new InventorPartsListRow(_partsList.PartsListRows[i]));
                    }
                }

                return rows;
            }
        }

        public int ColumnsCount => _partsList.PartsListColumns.Count;

        public int RowsCount => _partsList.PartsListRows.Count;

        public InventorHeaderPlacementEnum HeadingPlacement
        {
            get => (InventorHeaderPlacementEnum)_partsList.HeadingPlacement;
            set => _partsList.HeadingPlacement = (HeadingPlacementEnum)value;
        }

        public void Expand()
        {
            if (Level == InventorPartsListLevelEnum.StructuredAllLevels)
            {
                foreach (var row in Rows)
                {
                    if (row.Expandable && !row.Expanded)
                    {
                        row.Expanded = true;
                        Expand();
                    }
                }
            }
        }

        public void Renumber() => _partsList.Renumber();

        public void Dispose()
        {
            if (_partsList != null )
            {
                Marshal.ReleaseComObject(_partsList);
                _partsList = null;
            }

            if (Columns != null && Columns.Count > 0)
            {
                Columns.ForEach(x => x.Dispose());
            }

            if (Rows != null && Rows.Count > 0)
            {
                Rows.ForEach(x => x.Dispose());
            }
        }
    }

    public class InventorPartsListColumn : IDisposable
    {
        public PartsListColumn _partsListColumn;

        public void Remove() => _partsListColumn.Remove();

        public void Reposition(int target, bool insertBefore) => _partsListColumn.Reposition(target, insertBefore);

        public string CustomerPropertyName => _partsListColumn.CustomPropertyName;

        public InventorPropertyTypeEnum PropertyType => (InventorPropertyTypeEnum)_partsListColumn.PropertyType;

        public string Title
        {
            get => _partsListColumn.Title;
            set => _partsListColumn.Title = value;
        }

        public InventorHorizontalTextAlignment TitleHorizontalJustification
        {
            get => (InventorHorizontalTextAlignment)_partsListColumn.TitleHorizontalJustification;
            set => _partsListColumn.TitleHorizontalJustification = (HorizontalTextAlignmentEnum)value;
        }

        public InventorObjectTypes Type => (InventorObjectTypes)_partsListColumn.Type;

        public InventorHorizontalTextAlignment ValueHorizontalJustification
        {
            get => (InventorHorizontalTextAlignment)_partsListColumn.ValueHorizontalJustification;
            set => _partsListColumn.ValueHorizontalJustification = (HorizontalTextAlignmentEnum)value;
        }

        public double Width
        {
            get => _partsListColumn.Width;
            set => _partsListColumn.Width = value;
        }

        public InventorPartsListColumn(PartsListColumn partsListColumn)
        {
            _partsListColumn = partsListColumn;
        }

        public void Dispose()
        {
            if (_partsListColumn != null)
            {
                Marshal.ReleaseComObject(_partsListColumn);
                _partsListColumn = null;
            }
        }
    }

    public class InventorPartsListRow : IDisposable
    {
        public PartsListRow _partsListRow;

        public InventorPartsListRow(PartsListRow partsListRow)
        {
            _partsListRow = partsListRow;
        }

        public void Reposition(int target, bool insertBefore) => _partsListRow.Reposition(target, insertBefore);

        public void Remove() => _partsListRow.Remove();

        public bool Balooned => _partsListRow.Ballooned;

        public int CellsCount => _partsListRow.Count;

        public bool Custom => _partsListRow.Custom;

        public bool Expandable => _partsListRow.Expandable;

        public bool Expanded
        {
            get => _partsListRow.Expanded;
            set => _partsListRow.Expanded = value;
        }

        public double Height
        {
            get => _partsListRow.Height;
            set => _partsListRow.Height = value;
        }

        public InventorObjectTypes Type => (InventorObjectTypes)_partsListRow.Type;

        public bool Visible
        {
            get => _partsListRow.Visible;
            set => _partsListRow.Visible = value;
        }

        public List<InventorPartsListCell> Cells
        {
            get
            {
                var cells = new List<InventorPartsListCell>();

                if (CellsCount > 0)
                {
                    for (var i = 1; i <= CellsCount; i++)
                    {
                        cells.Add(new InventorPartsListCell(_partsListRow[i]));
                    }
                }

                return cells;
            }
        }

        public void Dispose()
        {
            if (_partsListRow != null )
            {
                Marshal.ReleaseComObject(_partsListRow);
                _partsListRow = null;
            }

            if (Cells != null && Cells.Count > 0)
            {
                Cells.ForEach(x => x.Dispose());
            }
        }
    }

    public class InventorPartsListCell : IDisposable
    {
        public PartsListCell _cell;

        public bool Static => _cell.Static;

        public InventorObjectTypes Type => (InventorObjectTypes)_cell.Type;

        public string Value
        {
            get => _cell.Value;
            set => _cell.Value = value;
        }

        public InventorPartsListCell(PartsListCell cell)
        {
            _cell = cell;
        }

        public void Dispose()
        {
            if ( _cell != null )
            {
                Marshal.ReleaseComObject(_cell);
                _cell = null;
            }
        }
    }
}
