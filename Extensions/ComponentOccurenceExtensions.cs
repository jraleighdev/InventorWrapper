using Inventor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Extensions
{
    /// <summary>
    /// Extensions for component occurrences
    /// </summary>
    public static class ComponentOccurenceExtensions
    {
        /// <summary>
        /// Get the occurence path as a list of strings
        /// </summary>
        /// <param name="occurrence"></param>
        /// <returns></returns>
        public static List<string> GetOccurencePath(this ComponentOccurrence occurrence)
        {
            var tempList = new List<string>();

            if (occurrence != null)
            {
                foreach (ComponentOccurrence c in occurrence.OccurrencePath)
                {
                    tempList.Add(c.Name);
                }
            }

            return tempList;
        }

        /// <summary>
        /// Gets the occurence path as large string
        /// </summary>
        /// <param name="occurrence"></param>
        /// <returns></returns>
        public static string GetOccurencePathString(this ComponentOccurrence occurrence)
        {
            string temp = "";

            if (occurrence != null)
            {
                foreach (ComponentOccurrence c in occurrence.OccurrencePath)
                {
                    temp += c.Name;
                }
            }

            return temp;
        }
    }
}
