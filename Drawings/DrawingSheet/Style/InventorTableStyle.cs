using Inventor;
using InventorWrapper.Drawings.Enums;
using InventorWrapper.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Drawings.DrawingSheet.Style
{
    public class InventorTableStyle : IDisposable
    {
        private InventorTextStyle _columnHeaderTextStyle;

        private InventorTextStyle _dataTextStyle;

        private InventorTextStyle _titleTextStyle;

        public TableStyle _tableStyle;

        public InventorTableStyle(TableStyle tableStyle)
        {
            _tableStyle = tableStyle;
        }

        public InventorTextStyle ColumnHeaderTextStyle
        {
            get
            {
                if (_columnHeaderTextStyle == null)
                {
                    _columnHeaderTextStyle = new InventorTextStyle(_tableStyle.ColumnHeaderTextStyle);
                }

                return _columnHeaderTextStyle;
            }
        }

        public InventorHorizontalTextAlignment ColumnTitleHorizontalJustification
        {
            get => (InventorHorizontalTextAlignment)_tableStyle.ColumnTitleHorizontalJustification;
            set => _tableStyle.ColumnTitleHorizontalJustification = (HorizontalTextAlignmentEnum)value;
        }

        public InventorHorizontalTextAlignment ColumnValueHorizontalJustification
        {
            get => (InventorHorizontalTextAlignment)_tableStyle.ColumnValueHorizontalJustification;
            set => _tableStyle.ColumnValueHorizontalJustification = (HorizontalTextAlignmentEnum)value;
        }

        public double ColumnWidth
        {
            get => _tableStyle.ColumnWidth;
            set => _tableStyle.ColumnWidth = value;
        }

        public string Comments
        {
            get => _tableStyle.Comments;
            set => _tableStyle.Comments = value;
        }

        public InventorTextStyle DataTextStyle
        {
            get
            {
                if (_dataTextStyle == null)
                {
                    _dataTextStyle = new InventorTextStyle(_tableStyle.DataTextStyle);
                }

                return _dataTextStyle;
            }
        }

        public double HeadingGap
        {
            get => _tableStyle.HeadingGap;
            set => _tableStyle.HeadingGap = value;
        }

        public InventorHeaderPlacementEnum HeadingPlacement
        {
            get => (InventorHeaderPlacementEnum)_tableStyle.HeadingPlacement;
            set => _tableStyle.HeadingPlacement = (HeadingPlacementEnum)value;
        }

        public double InsideLineWeight
        {
            get => _tableStyle.InsideLineWeight;
            set => _tableStyle.InsideLineWeight = value;
        }

        public bool InUse => _tableStyle.InUse;

        public string Name
        {
            get => _tableStyle.Name;
            set => _tableStyle.Name = value;
        }

        public double OutsideLineWeight
        {
            get => _tableStyle.OutsideLineWeight;
            set => _tableStyle.OutsideLineWeight = value;
        }

        public double RowGap
        {
            get => _tableStyle.RowGap;
            set => _tableStyle.RowGap = value;
        }

        public InventorLineSpacingEnum RowLineSpacing
        {
            get => (InventorLineSpacingEnum)_tableStyle.RowLineSpacing;
            set => _tableStyle.RowLineSpacing = (LineSpacingEnum)value;
        }

        public bool ShowTitle
        {
            get => _tableStyle.ShowTitle;
            set => _tableStyle.ShowTitle = value;
        }

        public InventorStyleTypeEnum StyleType => (InventorStyleTypeEnum)_tableStyle.StyleType;

        public InventorTableDirectionEnum TableDirection
        {
            get => (InventorTableDirectionEnum)_tableStyle.TableDirection;
            set => _tableStyle.TableDirection = (TableDirectionEnum)value;
        }

        public string Title
        {
            get => _tableStyle.Title;
            set => _tableStyle.Title = value;
        }

        public InventorTextStyle TitleTextStyle
        {
            get
            {
                if (_titleTextStyle == null)
                {
                    _titleTextStyle = new InventorTextStyle(_tableStyle.TitleTextStyle);
                }

                return _titleTextStyle;
            }
        }

        public InventorObjectTypes Type => (InventorObjectTypes)_tableStyle.Type;

        public bool UpToDate => _tableStyle.UpToDate;

        public void Dispose()
        {
            _columnHeaderTextStyle?.Dispose();

            _titleTextStyle?.Dispose();

            _dataTextStyle?.Dispose();

            if (_tableStyle != null)
            {
                Marshal.ReleaseComObject(_tableStyle);
                _tableStyle = null;
            }
        }
    }
}
