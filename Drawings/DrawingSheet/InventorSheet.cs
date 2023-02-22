using Inventor;
using InventorWrapper.Documents;
using InventorWrapper.Drawings.Curves;
using InventorWrapper.Drawings.DrawingSheet;
using InventorWrapper.Drawings.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

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
                if (_titleBlock == null)
                {
                    _titleBlock = new InventorTitleBlock(_sheet.TitleBlock);
                }

                return _titleBlock;
            }
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
                    x = parentView.Right + x;
                    y = parentView.Center.Y;
                    break;
            }

            return AddProjectedView(parentView, new Curves.Point(x, y), drawingViewStyle);
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
                bool refresh = _partsList == null ? true : _partsList.Count != _sheet.PartsLists.Count;

                if (refresh && _sheet.PartsLists.Count > 0)
                {
                    _partsList = new List<InventorPartsList>();

                    foreach (PartsList partList in _sheet.PartsLists)
                    {
                        _partsList.Add(new InventorPartsList(partList, this));
                    }

                    return _partsList;
                }

                return null;
            }
        }

        public List<InventorTable> Tables
        {
            get
            {
                bool refresh = _tables == null ? true : _tables.Count != _sheet.CustomTables.Count;

                if (refresh && _sheet.CustomTables.Count > 0)
                {
                    _tables = new List<InventorTable>();

                    foreach (CustomTable table in _sheet.CustomTables)
                    {
                        _tables.Add(new InventorTable(table, this));
                    }

                    return _tables;
                }

                return null;
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

        public InventorTable AddTable(string title, Curves.Point point, ref IEnumerable<string> titles, IEnumerable<string> contents, IEnumerable<double> columnWidths)
        {
            var refTitles = titles.ToArray();

            CustomTable table = _sheet.CustomTables.Add(title, point.CreatePoint(), titles.Count(), title.Count() / contents.Count(), ref refTitles, contents, columnWidths);

            return new InventorTable(table, this);
        }

        #endregion

        public void Dispose()
        {
            if (_sheet == null)
            {
                Marshal.ReleaseComObject(_sheet);
            }

            if (Border != null)
            {
                Border.Dispose();
            }
        }
    }
}
