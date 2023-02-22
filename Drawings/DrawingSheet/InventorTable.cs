using Inventor;
using InventorWrapper.Drawings.Enums;
using InventorWrapper.Enums;
using InventorWrapper.IProps;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace InventorWrapper.Drawings.DrawingSheet
{
    public class InventorTable : IDisposable
    {
        public CustomTable _table;

        public InventorSheet Parent { get; private set; }

        public InventorTable(CustomTable table, InventorSheet parent)
        {
            _table = table;
            Parent = parent;    
        }

        public InventorObjectTypes Type => (InventorObjectTypes)_table.Type;

        public Curves.Point BottomLeft => new Curves.Point(_table.RangeBox.MinPoint);

        public Curves.Point BottomRight => new Curves.Point(_table.RangeBox.MaxPoint.X, _table.RangeBox.MinPoint.Y);

        public Curves.Point TopRight => new Curves.Point(_table.RangeBox.MaxPoint);

        public Curves.Point TopLeft => new Curves.Point(_table.RangeBox.MinPoint.X, _table.RangeBox.MaxPoint.Y);

        public double Height => Math.Abs(TopLeft.Y - BottomLeft.Y);

        public double Width => Math.Abs(BottomRight.X - BottomLeft.X);

        public InventorHeaderPlacementEnum HeadingPlacement
        {
            get => (InventorHeaderPlacementEnum)_table.HeadingPlacement;
            set => _table.HeadingPlacement = (HeadingPlacementEnum)value;
        }

        public int MaximumRows
        {
            get => _table.MaximumRows;
            set => _table.MaximumRows = value;
        }

        public int NumberOfSections
        {
            get => _table.NumberOfSections;
            set => _table.NumberOfSections = value;
        }

        public double RowGap
        {
            get => _table.RowGap;
        }

        public InventorLineSpacingEnum LineSpacing
        {
            get => (InventorLineSpacingEnum)_table.RowLineSpacing;
            set => _table.RowLineSpacing = (LineSpacingEnum)value;
        }

        public Curves.Point Position
        {
            get => new Curves.Point(_table.Position);
            set => _table.Position = value.CreatePoint();
        }

        public string Title
        {
            get => _table.Title;
            set => _table.Title = value;
        }

        public bool ShowTitle
        {
            get => _table.ShowTitle;
            set => _table.ShowTitle = value;
        }

        public InventorTableDirectionEnum TableDirection
        {
            get => (InventorTableDirectionEnum)_table.TableDirection;
            set => _table.TableDirection = (TableDirectionEnum)value;
        }

        public bool WrapAutomatically
        {
            get => _table.WrapAutomatically;
            set => _table.WrapAutomatically = value;
        }

        public bool WrapLeft
        {
            get => _table.WrapLeft;
            set => _table.WrapLeft = value;
        }

        public void Sort(string primaryColumn, bool primaryAsc = true, string secColumn = "", bool secAsc = true, string terColumn = "",  bool terAsc = true)
        {
            _table.Sort(primaryColumn, primaryAsc, secColumn, secAsc, terColumn, terAsc);
        }

        public void Dispose()
        {
            if (_table != null)
            {
                Marshal.ReleaseComObject(_table);
                _table = null;
            }
        }
    }

    public class InventorColumn : IDisposable
    {
        public Column _column;

        public void Remove() => _column.Delete();

        public void Reposition(int target, bool insertBefore) => _column.Reposition(target, insertBefore);

        public string Title
        {
            get => _column.Title;
            set => _column.Title = value;
        }

        public string InternalTitle => _column.InternalTitle;

        public InventorHorizontalTextAlignment TitleHorizontalJustification
        {
            get => (InventorHorizontalTextAlignment)_column.TitleHorizontalJustification;
            set => _column.TitleHorizontalJustification = (HorizontalTextAlignmentEnum)value;
        }

        public InventorObjectTypes Type => (InventorObjectTypes)_column.Type;

        public InventorHorizontalTextAlignment ValueHorizontalJustification
        {
            get => (InventorHorizontalTextAlignment)_column.ValueHorizontalJustification;
            set => _column.ValueHorizontalJustification = (HorizontalTextAlignmentEnum)value;
        }

        public double Width
        {
            get => _column.Width;
            set => _column.Width = value;
        }

        public InventorColumn(Column column)
        {
            _column = column;
        }

        public void Dispose()
        {
            if (_column != null)
            {
                Marshal.ReleaseComObject(_column);
                _column = null;
            }
        }
    }

    public class InventorRow : IDisposable
    {
        public Row _row;

        public InventorRow(Row row)
        {
            _row = row;
        }

        public void Reposition(int target, bool insertBefore) => _row.Reposition(target, insertBefore);

        public void Remove() => _row.Delete();

        public int CellsCount => _row.Count;

        public double Height
        {
            get => _row.Height;
            set => _row.Height = value;
        }

        public InventorObjectTypes Type => (InventorObjectTypes)_row.Type;

        public bool Visible
        {
            get => _row.Visible;
            set => _row.Visible = value;
        }

        public List<InventorCell> Cells
        {
            get
            {
                var cells = new List<InventorCell>();

                if (CellsCount > 0)
                {
                    for (var i = 1; i <= CellsCount; i++)
                    {
                        cells.Add(new InventorCell(_row[i]));
                    }
                }

                return cells;
            }
        }

        public void Dispose()
        {
            if (_row != null)
            {
                Marshal.ReleaseComObject(_row);
                _row = null;
            }

            if (Cells != null && Cells.Count > 0)
            {
                Cells.ForEach(x => x.Dispose());
            }
        }
    }

    public class InventorCell : IDisposable
    {
        public Cell _cell;

        public bool Static => _cell.Static;

        public InventorObjectTypes Type => (InventorObjectTypes)_cell.Type;

        public string Value
        {
            get => _cell.Value;
            set => _cell.Value = value;
        }

        public InventorCell(Cell cell)
        {
            _cell = cell;
        }

        public void Dispose()
        {
            if (_cell != null)
            {
                Marshal.ReleaseComObject(_cell);
                _cell = null;
            }
        }
    }
}
