using Inventor;
using InventorWrapper.Drawings.Enums;
using InventorWrapper.Enums;
using InventorWrapper.IProps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using InventorWrapper.Drawings.Curves;
using InventorWrapper.Drawings.DrawingSheet.Style;

namespace InventorWrapper.Drawings.DrawingSheet
{
    public class InventorTable : IDisposable
    {
        public CustomTable _table;

        private List<InventorColumn> _columns;

        private List<InventorRow> _rows;

        private InventorTableStyle _style;

        public InventorSheet Parent { get; private set; }

        public InventorTable(CustomTable table, InventorSheet parent)
        {
            _table = table;
            Parent = parent;    
        }

        public int ColumnsCount => _table.Columns.Count;

        public int RowsCount => _table.Rows.Count;

        /// <summary>
        /// Add a column to the table
        /// </summary>
        /// <param name="title"></param>
        /// <param name="targetIndex"></param>
        /// <param name="insertBefore"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        public InventorColumn AddColumn(string title, int targetIndex = 0, bool insertBefore = true, double? width = null)
        {
            var column = new InventorColumn(_table.Columns.Add(title, targetIndex, insertBefore, width));

            Columns.Add(column);

            return column;
        }

        /// <summary>
        /// Add row to the table
        /// </summary>
        /// <param name="targetIndex"></param>
        /// <param name="insertBefore"></param>
        /// <param name="contents">array strings must match the number of columns in the table</param>
        /// <param name="height"></param>
        /// <returns></returns>
        public InventorRow AddRow(int targetIndex = 0, bool insertBefore = true, IEnumerable<string> contents = null, double? height = null)
        {
            var row = new InventorRow(_table.Rows.Add(targetIndex, insertBefore, contents?.ToArray(), height));

            Rows.Add(row);

            return row;
        }
             
        public List<InventorColumn> Columns
        {
            get
            {
                bool refresh = _columns == null || ColumnsCount != _columns.Count;

                if (refresh)
                {
                    _columns = new List<InventorColumn>();

                    foreach (Column col in _table.Columns)
                    {
                        _columns.Add(new InventorColumn(col));
                    }
                }

                return _columns;
            }
        }

        public List<InventorRow> Rows
        {
            get
            {
                bool refresh = _rows == null || RowsCount != _rows.Count;

                if (refresh)
                {
                    _rows = new List<InventorRow>();

                    foreach (Row row in _table.Rows)
                    {
                        _rows.Add(new InventorRow(row));
                    }
                }

                return _rows;
            }
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

        public InventorTableStyle Style
        {
            get
            {
                if (_style == null)
                {
                    _style = new InventorTableStyle(_table.Style);
                }

                return _style;
            }
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

        /// <summary>
        /// Moves to table position to place right top point at current position.
        /// </summary>
        public void AdjustPositionToRightTopPoint()
        {
            Position = new Curves.Point(Position.X - Width, Position.Y);
        }

        public void Dispose()
        {
            _style?.Dispose();

            if (_columns != null && _columns.Count > 0)
            {
                _columns.ForEach(x => x.Dispose());
            }

            if (_rows != null && _rows.Count > 0)
            {
                _rows.ForEach(x => x.Dispose());
            }

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
            if (Cells != null && Cells.Count > 0)
            {
                Cells.ForEach(x => x.Dispose());
            }

            if (_row != null)
            {
                Marshal.ReleaseComObject(_row);
                _row = null;
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
