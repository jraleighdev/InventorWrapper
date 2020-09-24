using Inventor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.General
{
    public static class UnitManager
    {
        public static UnitTypes UnitTypes { get; set; } = UnitTypes.In;

        public static double UnitsToInventor(double value)
        {
            switch (UnitTypes)
            {
                case UnitTypes.In:
                    return value * 2.54;
                case UnitTypes.M:
                    return value * 10;
                case UnitTypes.MM:
                    return value / 10;
                default:
                    return value;
            }
        }

        public static double UnitsFromInventor(double value)
        {
            switch (UnitTypes)
            {
                case UnitTypes.In:
                    return value / 2.54;
                case UnitTypes.M:
                    return value / 10;
                case UnitTypes.MM:
                    return value * 10;
                default:
                    return value;
            }
        }

        public static double ConvertDegrees(double value)
        {
            double constant = Math.PI / 180;

            return value * constant;
        }
    }
}
