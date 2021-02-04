using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.General
{
    public static class UnitManager
    {
        public static LengthUnits LengthUnits { get; set; } = LengthUnits.In;

        public static AngularUnits AngularUnits { get; set; } = AngularUnits.Degrees;

        public static List<LengthUnits> MeasurementUnits
        {
            get
            {
                return new List<LengthUnits> { LengthUnits.In, LengthUnits.M, LengthUnits.MM };
            }
        }

        public static List<AngularUnits> AngularMeasurementUnits
        {
            get
            {
                return new List<AngularUnits> { AngularUnits.Degrees, AngularUnits.Radians };
            }
        }

        public static double UnitsToInventor(double value, UnitTypes unitTypes = UnitTypes.Length)
        {
            switch (unitTypes)
            {
                case UnitTypes.Length:
                    switch (LengthUnits)
                    {
                        case LengthUnits.In:
                            return value * 2.54;
                        case LengthUnits.M:
                            return value * 10;
                        case LengthUnits.MM:
                            return value / 10;
                        default:
                            return value;
                    }
                case UnitTypes.Angular:
                    switch (AngularUnits)
                    {
                        case AngularUnits.Degrees:
                            return ConvertDegrees(value);
                        default:
                            return value;
                    }
                default:
                    return value;
            }

            
        }

        public static double UnitsFromInventor(double value, UnitTypes unitTypes = UnitTypes.Length)
        {
            switch (unitTypes)
            {
                case UnitTypes.Length:
                    switch (LengthUnits)
                    {
                        case LengthUnits.In:
                            return value / 2.54;
                        case LengthUnits.M:
                            return value / 10;
                        case LengthUnits.MM:
                            return value * 10;
                        default:
                            return value;
                    }
                case UnitTypes.Angular:
                    switch (AngularUnits)
                    {
                        case AngularUnits.Degrees:
                            return ConvertRadians(value);
                        default:
                            return value;
                    }
                default:
                    return value;
            }

            
        }

        public static double ConvertDegrees(double value)
        {
            double constant = Math.PI / 180;

            return value * constant;
        }

        public static double ConvertRadians(double value)
        {
            double constant = 180 / Math.PI;

            return value * constant;
        }
    }
}
