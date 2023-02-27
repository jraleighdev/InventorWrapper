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

        private List<InventorPartsListColumn> _columns;

        private List<InventorPartsListRow> _rows;

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
        /// <param name="propertyIdentifier"></param>
        /// <param name="width"></param>
        /// <param name="index"></param>
        /// <param name="internalName">Internal name of the property set we are trying to add</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public InventorPartsListColumn AddColumn(InventorPropertyTypeEnum propType, IpropertyEnum iproperty, int target, bool insertBefore, string propertyIdentifier = "", double width = .5, int index = 0, string internalName = "")
        {
            if (target > ColumnsCount)
            {
                throw new Exception($"target ${target} cannnot be greater than {ColumnsCount}");
            }

            PartsListColumn col = null;

            if (propType == InventorPropertyTypeEnum.FileProperty)
            {
                try
                {
                    var propId = int.TryParse(propertyIdentifier, out var value);

                    if (propId)
                    {
                        col = _partsList.PartsListColumns.Add(PropertyTypeEnum.kFileProperty, internalName,
                            value, target, insertBefore);
                    }
                }
                catch (Exception ex)
                {
                    Parent.Errors.Add(ex);
                }
            }
            else if (propType == InventorPropertyTypeEnum.CustomProperty)
            {
                if (!Columns.Any(x => x.Title == propertyIdentifier))
                {
                    try
                    {
                        col = _partsList.PartsListColumns.Add((PropertyTypeEnum)propType, "", propertyIdentifier, target, insertBefore);
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
                col.Width = width;

                var column = new InventorPartsListColumn(col);

                Columns.Add(column);

                return column;
            }

            return null;
        }

        public List<InventorPartsListColumn> Columns
        {
            get
            {
                bool refresh = _columns == null || ColumnsCount != _columns.Count;

                if (refresh)
                {
                    _columns = new List<InventorPartsListColumn>();

                    foreach (PartsListColumn col in _partsList.PartsListColumns)
                    {
                        _columns.Add(new InventorPartsListColumn(col));
                    }
                }

                return _columns;
            }
        }

        public List<InventorPartsListRow> Rows
        {
            get
            {
                bool refresh = _rows == null || RowsCount != _rows.Count;

                if (refresh)
                {
                    _rows = new List<InventorPartsListRow>();

                    foreach (PartsListRow row in _partsList.PartsListRows)
                    {
                        _rows.Add(new InventorPartsListRow(row));
                    }
                }

                return _rows;
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
            if (_columns != null && _columns.Count > 0)
            {
                _columns.ForEach(x => x.Dispose());
            }

            if (_rows != null && _rows.Count > 0)
            {
                _rows.ForEach(x => x.Dispose());
            }

            if (_partsList != null )
            {
                Marshal.ReleaseComObject(_partsList);
                _partsList = null;
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
            if (Cells != null && Cells.Count > 0)
            {
                Cells.ForEach(x => x.Dispose());
            }

            if (_partsListRow != null )
            {
                Marshal.ReleaseComObject(_partsListRow);
                _partsListRow = null;
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
