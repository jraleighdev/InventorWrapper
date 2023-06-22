using Inventor;
using InventorWrapper.Documents;
using InventorWrapper.Drawings.Curves;
using InventorWrapper.Drawings.DrawingSheet;
using InventorWrapper.Drawings.Enums;
using InventorWrapper.Drawings.Helpers.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using InventorWrapper.Drawings.Annotations;
using InventorWrapper.Drawings.DrawingSheet.Style;

namespace InventorWrapper.Drawings
{
    public class InventorSheet : IDisposable
    {
        public Sheet _sheet;

        private InventorTitleBlock _titleBlock;

        private List<InventorPartsList> _partsList;

        private List<InventorTable> _tables;

        public List<InventorView> Views { get; set; }

        public List<Exception> Errors { get; set; }

        public void Activate() => _sheet.Activate();

        public void AddBorder() => _sheet.AddDefaultBorder();

        public InventorBorder Border
        {
            get
            {
                if (_sheet.Border != null)
                {
                    return new InventorBorder(_sheet.Border);
                }

                return null;
            }
        }

        public void Delete() => _sheet.Delete();

        public double Height => _sheet.Height;

        public double Width => _sheet.Width;

        public string Name => _sheet.Name;

        public InventorTitleBlock TitleBlock
        {
            get
            {
                if (_sheet.TitleBlock == null) return null;
                
                if (_titleBlock == null)
                {
                    _titleBlock = new InventorTitleBlock(_sheet.TitleBlock);
                }

                return _titleBlock;
            }
        }

        public InventorTitleBlock AddTitleBlock(string name, InventorTitleBlockLocationEnum location = InventorTitleBlockLocationEnum.kBottomRightPosition, IEnumerable<string> prompts = null)
        {
            return new InventorTitleBlock(_sheet.AddTitleBlock(name, (TitleBlockLocationEnum)location, prompts?.ToArray()));
        }

        public InventorSheet(Sheet sheet)
        {
            Errors = new List<Exception>();
            _sheet = sheet;
            Views = new List<InventorView>();

            GetViews();
        }

        #region Views

        public InventorView AddBaseView(InventorDocument document, Curves.Point point, double scale, InventorViewOrientaionType viewOrientaionType, InventorDrawingViewStyle inventorDrawingViewStyle, string modelViewName = "")
        {
            var view = new InventorView(_sheet.DrawingViews.AddBaseView((_Document)document._document, point.CreatePoint(), scale, (ViewOrientationTypeEnum)viewOrientaionType, (DrawingViewStyleEnum)inventorDrawingViewStyle, modelViewName), this);

            Views.Add(view);

            return view;
        }

        public InventorView AddProjectedView(InventorView parentView, Curves.Point point, InventorDrawingViewStyle inventorDrawingViewStyle)
        {
            var view = new InventorView(_sheet.DrawingViews.AddProjectedView(parentView._view, point.CreatePoint(), (DrawingViewStyleEnum)inventorDrawingViewStyle), this);

            Views.Add(view);

            return view;
        }

        public InventorView AddProjectedView(InventorView parentView, ProjectedViewDirection viewDirection, double offset = 5, InventorDrawingViewStyle drawingViewStyle = InventorDrawingViewStyle.FromBaseDrawing)
        {
            var x = 0.00;
            var y = 0.00;

            switch (viewDirection)
            {
                case ProjectedViewDirection.Top:
                    x = parentView.Center.X;
                    y = parentView.Top + offset;
                    break;
                case ProjectedViewDirection.Left:
                    x = parentView.Left - offset;
                    y = parentView.Center.Y;
                    break;
                case ProjectedViewDirection.Bottom:
                    x = parentView.Center.X;
                    y = parentView.Bottom - offset;
                    break;
                case ProjectedViewDirection.Right:
                    x = parentView.Right + offset;
                    y = parentView.Center.Y;
                    break;
            }

            return AddProjectedView(parentView, new Curves.Point(x, y), drawingViewStyle);
        }

        public InventorDetailDrawingView AddDetailViewByCenter(InventorView view, Curves.Point location, bool circularFence, Curves.Point center, double radius, Curves.Point attachment = null, InventorDrawingViewStyle viewStyle = InventorDrawingViewStyle.FromBaseDrawing)
        {
            return new InventorDetailDrawingView(_sheet.DrawingViews.AddDetailView(view._view, location.CreatePoint(), (DrawingViewStyleEnum)viewStyle,
                circularFence, center.CreatePoint(), radius), this);
        }
        
        public InventorDetailDrawingView AddDetailViewByExtremes(InventorView view, Curves.Point location, bool circularFence, Curves.Point pointOne, Curves.Point pointTwo, Curves.Point attachment = null, InventorDrawingViewStyle viewStyle = InventorDrawingViewStyle.FromBaseDrawing)
        {
            return new InventorDetailDrawingView(_sheet.DrawingViews.AddDetailView(view._view, location.CreatePoint(), (DrawingViewStyleEnum)viewStyle,
                circularFence, pointOne.CreatePoint(), pointTwo.CreatePoint()), this);
        }


        private void GetViews()
        {
            Views.Clear();

            foreach (DrawingView v in _sheet.DrawingViews)
            {
                Views.Add(new InventorView(v, this));
            }
        }

        #endregion

        #region Tables

        public List<InventorPartsList> PartsLists
        {
            get
            {
                bool refresh = _partsList == null || _partsList.Count != _sheet.PartsLists.Count;

                if (refresh && _sheet.PartsLists.Count > 0)
                {
                    _partsList = new List<InventorPartsList>();

                    foreach (PartsList partList in _sheet.PartsLists)
                    {
                        _partsList.Add(new InventorPartsList(partList, this));
                    }
                }

                return _partsList;
            }
        }

        public List<InventorTable> Tables
        {
            get
            {
                bool refresh = _tables == null || _tables.Count != _sheet.CustomTables.Count;

                if (refresh && _sheet.CustomTables.Count > 0)
                {
                    _tables = new List<InventorTable>();

                    foreach (CustomTable table in _sheet.CustomTables)
                    {
                        _tables.Add(new InventorTable(table, this));
                    }

                }

                return _tables;
            }
        }

        public InventorPartsList AddPartsList(InventorView view, InventorPartsListLevelEnum level, bool expanded, string title, Curves.Point optionalPoint = null, string delimiter = "-", InventorHeaderPlacementEnum inventorHeaderPlacementEnum = InventorHeaderPlacementEnum.HeadingAtTop)
        {
            if (!view.Document.IsAssemblyDoc) return null;

            var aDoc = view.Document.GetAssemblyDocument();

            if (level == InventorPartsListLevelEnum.StructuredAllLevels)
            {
                var adocSetter = InventorApplication.Open(aDoc, false).GetAssemblyDocument();

                var bom = adocSetter.Bom;

                try
                {
                    bom.StructureViewFirstLevelOnly = false;
                    bom.StructuredViewEnabled = true;
                    bom.StructuredViewDelimiter = delimiter;
                }
                catch(Exception ex)
                {
                    Errors.Add(ex);
                }
                finally
                {
                    adocSetter.Save();
                    adocSetter.Close();
                }
            }
            else if (level == InventorPartsListLevelEnum.Structured)
            {
                var adocSetter = InventorApplication.Open(aDoc, false).GetAssemblyDocument();

                var bom = adocSetter.Bom;

                try
                {
                    bom.StructureViewFirstLevelOnly = true;
                    bom.StructuredViewEnabled = true;
                    bom.StructuredViewDelimiter = delimiter;
                }
                catch (Exception ex)
                {
                    Errors.Add(ex);
                }
                finally
                {
                    adocSetter.Save();
                    adocSetter.Close();
                }
            }

            var point = optionalPoint == null ? _sheet.Border.RangeBox.MaxPoint : optionalPoint.CreatePoint();

            try
            {
                var partsList = new InventorPartsList(_sheet.PartsLists.Add(view._view, point, (PartsListLevelEnum)level), this);

                partsList.HeadingPlacement = inventorHeaderPlacementEnum;

                if (expanded) partsList.Expand();

                partsList.Renumber();

                return partsList;
            }
            catch (Exception ex)
            { 
                Errors.Add(ex); 
            }

            return null;
        } 

        /// <summary>
        /// Creates an inventor custom table
        /// </summary>
        /// <param name="title"></param>
        /// <param name="point"></param>
        /// <param name="columnCount"></param>
        /// <param name="rowCount"></param>
        /// <param name="titles">Titles of each column must be equal to column count or an error will occur</param>
        /// <param name="contents">Content is passed in row wise must match the number of cells in the table or an error will occur</param>
        /// <param name="columnWidths"></param>
        /// <returns></returns>
        public InventorTable AddTable(string title, Curves.Point point, int columnCount, int rowCount, IEnumerable<string> titles, IEnumerable<string> contents = null, IEnumerable<double> columnWidths = null, IEnumerable<double> rowHeights = null)
        {
            var refTitles = titles.ToArray();

            CustomTable table = _sheet.CustomTables.Add(title, point.CreatePoint(), columnCount, rowCount, ref refTitles, contents?.ToArray(), columnWidths?.ToArray(), rowHeights?.ToArray());

            return new InventorTable(table, this);
        }

        /// <summary>
        /// Creates an inventor table using a dto
        /// </summary>
        /// <param name="inventorTableDto"></param>
        /// <param name="tableLocation"></param>
        /// <returns></returns>
        public InventorTable AddTable(InventorTableDto inventorTableDto, Curves.Point tableLocation)
        {
            var titles = inventorTableDto.Columns.Select(x => x.Title).ToArray();

            var data = new List<Tuple<string, int>>();

            foreach (var col in inventorTableDto.Columns) 
            {
                foreach (var row in col.RowData)
                {
                    data.Add(new Tuple<string, int>(row, col.RowData.IndexOf(row)));
                }
            }

            var dataAr = data.OrderBy(x => x.Item2);

            var rowData = dataAr.Select(x => x.Item1).ToArray();

            var columnWidths = inventorTableDto.Columns.Select(x => x.Width).ToArray();

            var table = new InventorTable(_sheet.CustomTables.Add(inventorTableDto.Title, tableLocation.CreatePoint(), inventorTableDto.ColumnQty, inventorTableDto.RowQty, titles, rowData, columnWidths), this);

            for (var i = 0; i <= table.Columns.Count - 1; i++)
            {
                var dto = inventorTableDto.Columns[i];

                var column = table.Columns[i];

                column.TitleHorizontalJustification = dto.HeaderTextAlignment;

                column.ValueHorizontalJustification = dto.DataTextAlignment;
            }

            return table;
        }

        #endregion

        #region Notes

        public List<InventorGeneralNote> GeneralNotes
        {
            get
            {
                var notes = new List<InventorGeneralNote>();

                foreach (GeneralNote generalNote in _sheet.DrawingNotes.GeneralNotes)
                {
                    notes.Add(new InventorGeneralNote(generalNote));
                }

                return notes;
            }
        }
        
        public void DeleteGeneralNotes()
        {
            for (var i = _sheet.DrawingNotes.GeneralNotes.Count; i > 0; i--)
            {
                _sheet.DrawingNotes.GeneralNotes[i].Delete();
            }
        }

        public InventorGeneralNote AddGeneralNote(Curves.Point point, string text, InventorTextStyle textStyle = null)
        {
            var note = new InventorGeneralNote(_sheet.DrawingNotes.GeneralNotes.AddFitted(point.CreatePoint(), text, textStyle));
            
            return note;
        }

        public void DeleteLeaderNotes()
        {
            for (var i = _sheet.DrawingNotes.LeaderNotes.Count; i > 0; i--)
            {
                _sheet.DrawingNotes.LeaderNotes[i].Delete();
            }
        }
        
        public InventorLeaderNote AddLeaderNote(List<Curves.Point> points, string text)
        {
            var objCol = InventorApplication.CreateObjectCollection();

            foreach (var point in points)
            {
                objCol.Add(point);
            }

            var note = new InventorLeaderNote(_sheet.DrawingNotes.LeaderNotes.Add(objCol, text));

            Marshal.ReleaseComObject(objCol);

            return note;
        }
        
        #endregion

        public void Dispose()
        {
            Border?.Dispose();

            if (_sheet == null)
            {
                Marshal.ReleaseComObject(_sheet);
            }
        }
    }
}
