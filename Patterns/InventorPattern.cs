using Inventor;
using InventorWrapper.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Patterns
{
    public class InventorPattern : IDisposable
    {
        public OccurrencePattern _pattern;

        private List<InventorComponent> _occurences;

        public List<InventorComponent> Occurences
        {
            get
            {
                if (_occurences == null)
                {
                    _occurences = new List<InventorComponent>();

                    int count = _pattern.OccurrencePatternElements.Count;

                    for (int i = 1; i <= count; i++)
                    {
                        OccurrencePatternElement occelement = _pattern.OccurrencePatternElements[i];

                        ComponentOccurrencesEnumerator occenum = occelement.Occurrences;

                        foreach (ComponentOccurrence occ in occenum)
                        {
                            _occurences.Add(new InventorComponent(occ));
                        } //next
                    }
                }

                return _occurences;
            }
        }

        public string Name => _pattern.Name;

        public bool IsPatternElement => _pattern.IsPatternElement;

        public bool IsSuppressed => Occurences.Any(x => x.Suppressed);

        public InventorPattern(OccurrencePattern pattern)
        {
            _pattern = pattern;
        }

        public void Dispose()
        {
            if (_pattern != null)
            {
                Marshal.ReleaseComObject(_pattern);
            }
        }
    }
}
