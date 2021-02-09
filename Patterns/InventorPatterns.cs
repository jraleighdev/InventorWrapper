using Inventor;
using InventorWrapper.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Patterns
{
    /// <summary>
    /// Patterns in the for the referenced assembly document
    /// </summary>
    public class InventorPatterns : List<InventorPattern>
    {
        private InventorAssemblyDocument _adoc;

        public InventorPatterns(InventorAssemblyDocument adoc)
        {
            _adoc = adoc;

            GetPatterns();
        }

        /// <summary>
        /// Suppresses a pattern by the given name
        /// </summary>
        /// <param name="pattern"></param>
        /// <param name="status"></param>
        /// <exception cref="Exception"></exception>
        public void SuppressPattern(string pattern, bool status)
        {
            OccurrencePattern occPattern = null;

            try
            {
                occPattern = _adoc._adef.OccurrencePatterns[pattern];
            }
            catch
            {
                throw new Exception("Could not find pattern " + pattern);
            }

            int count = occPattern.OccurrencePatternElements.Count;

            for (int i = 1; i <= count; i++)
            {
                OccurrencePatternElement occelement = occPattern.OccurrencePatternElements[i];

                ComponentOccurrencesEnumerator occenum = occelement.Occurrences;

                foreach (ComponentOccurrence occ in occenum)
                {
                    if (status)
                    {
                        occ.BOMStructure = BOMStructureEnum.kReferenceBOMStructure;
                        occ.Suppress();
                    }
                    else
                    {
                        occ.Unsuppress();
                        occ.BOMStructure = BOMStructureEnum.kDefaultBOMStructure;
                    }
                } //next
            }
        }

        /// <summary>
        /// Gets all the patterns
        /// </summary>
        private void GetPatterns()
        {
            foreach (OccurrencePattern pattern in _adoc._adef.OccurrencePatterns)
            {
                Add(new InventorPattern(pattern));
            }
        }
    }
}
