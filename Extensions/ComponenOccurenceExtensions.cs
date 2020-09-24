using Inventor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Extensions
{
    public static class ComponenOccurenceExtensions
    {
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
