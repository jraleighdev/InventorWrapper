using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.General
{
    /// <summary>
    /// Used for managing unit interaction with inventor
    /// </summary>
    public static class UnitManager
    {
        /// <summary>
        /// Length units the wrapper is sending to inventor
        /// </summary>
        public static LengthUnits LengthUnits { get; set; } = LengthUnits.In;

        /// <summary>
        /// Angular units the wrapper is sending to inventor
        /// </summary>
        public static AngularUnits AngularUnits { get; set; } = AngularUnits.Degrees;

        /// <summary>
        /// List of the length units
        /// </summary>
        public static List<LengthUnits> MeasurementUnits
        {
            get
            {
                return new List<LengthUnits> { LengthUnits.In, LengthUnits.M, LengthUnits.MM };
            }
        }

        /// <summary>
        /// List of angular units
        /// </summary>
        public static List<AngularUnits> AngularMeasurementUnits
        {
            get
            {
                return new List<AngularUnits> { AngularUnits.Degrees, AngularUnits.Radians };
            }
        }

        /// <summary>
        /// Takes given value and sends to inventor
        /// If the unit type is length then the value is converted to centimeters
        /// If the unit type is angular then the value is converted to radians
        /// Other units types are sent as is
        /// </summary>
        /// <param name="value"></param>
        /// <param name="unitTypes"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Takes given value from inventor and converts to user specified
        /// If the unit type is length then the value is converted to user specified length units
        /// If the unit type is angular then the value is converted to user specified angular units 
        /// Other unit types are retrieved as is
        /// </summary>
        /// <param name="value"></param>
        /// <param name="unitTypes"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Converts degrees to radians
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double ConvertDegrees(double value)
        {
            double constant = Math.PI / 180;

            return value * constant;
        }

        /// <summary>
        /// Convert radians to degrees
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double ConvertRadians(double value)
        {
            double constant = 180 / Math.PI;

            return value * constant;
        }
    }
}
