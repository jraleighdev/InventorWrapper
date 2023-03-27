using System;
using System.Runtime.InteropServices;
using Inventor;
using InventorWrapper.Drawings.Curves;
using InventorWrapper.Drawings.DrawingSheet.Style;
using InventorWrapper.Drawings.Enums;
using InventorWrapper.Enums;
using Microsoft.SqlServer.Server;
using Point = InventorWrapper.Drawings.Curves.Point;

namespace InventorWrapper.Drawings.Annotations
{
    public class InventorLeaderNote : InventorDrawingNote
    {
        public LeaderNote _leaderNote;
        
        private InventorLeader _leader;
        
        public InventorLeaderNote(LeaderNote leaderNote) : base((DrawingNote)leaderNote)
        {
            _leaderNote = leaderNote;
        }
        
        public InventorLeader Leader
        {
            get
            {
                if (_leader == null)
                {
                    _leader = new InventorLeader(_leaderNote.Leader);
                }

                return _leader;
            }
        }

        public bool UseBackGroundColor
        {
            get => _leaderNote.UseBackgroundColor;
            set => _leaderNote.UseBackgroundColor = value;
        }

        public override void Dispose()
        {
            if (_leaderNote != null)
            {
                _leader?.Dispose();

                Marshal.ReleaseComObject(_leaderNote);
                _leaderNote = null;
            }
        }
    }
}