using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Helpers
{
    /// <summary>
    /// Helpers for getting metadata from enums
    /// </summary>
    public static class EnumHelpers
    {
        /// <summary>
        /// Get the description attribute from the enum
        /// </summary>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static string GetDescription(this Enum enumValue)
        {
            //Look for DescriptionAttributes on the enum field
            object[] attr = enumValue.GetType().GetField(enumValue.ToString())
                .GetCustomAttributes(typeof(DescriptionAttribute), false);

            // a DescriptionAttribute exists; use it
            if (attr.Length > 0)
            {
                return ((DescriptionAttribute)attr[0]).Description;
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// Get the category attribute from the enum
        /// </summary>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static string GetCategory(this Enum enumValue)
        {
            //Look for DescriptionAttributes on the enum field
            object[] attr = enumValue.GetType().GetField(enumValue.ToString())
                .GetCustomAttributes(typeof(CategoryAttribute), false);

            // a DescriptionAttribute exists; use it
            if (attr.Length > 0)
            {
                return ((CategoryAttribute)attr[0]).Category;
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// Converts an enum to a list of strings
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<string> EnumToList<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T)).Cast<T>().Select(x => x.ToString()).ToList();
        }
    }
}
