using Inventor;
using InventorWrapper.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Parameters
{
    public class InventorParameter : IDisposable
    {
        private Parameter _parameter;

        public UnitTypes UnitType { get; private set; }

        public LengthUnits LengthUnit { get; private set; }

        public AngularUnits AngularUnit { get; private set; }

        public string Name
        {
            get => _parameter.Name;

            set => _parameter.Name = value;
        }

        /// <summary>
        /// Base value from inventor
        /// Centimeters if it is a length unit
        /// Radians if a angular unit
        /// </summary>
        public dynamic Value
        {
            get => _parameter.Value;

            set => _parameter.Value = value;
        }

        /// <summary>
        /// Returns the units converted to the standard specified in the unit manager
        /// </summary>
        public dynamic ConvertedValue
        {
            get
            {
                if (_parameter.Value == null) return null;

                var result = double.TryParse(_parameter.Value?.ToString(), out double tempValue);

                if (UnitType == UnitTypes.Length && result)
                {
                    return UnitManager.UnitsFromInventor(tempValue);
                }
                else if (UnitType == UnitTypes.Angular && result)
                {
                    return UnitManager.UnitsFromInventor(tempValue, UnitTypes.Angular);
                }

                return _parameter.Value;
            }
        }

        /// <summary>
        /// If Parameter is a user created parameter
        /// </summary>
        public bool IsUser => _parameter.ParameterType == ParameterTypeEnum.kUserParameter;

        /// <summary>
        /// Get the expression that evaluates to the parameter
        /// </summary>
        public string Expression
        {
            get => _parameter.Expression;

            set => _parameter.Expression = value;
        }

        /// <summary>
        /// The type of units for the parameter
        /// </summary>
        public string Units
        {
            get => _parameter.get_Units();

            set => _parameter.set_Units(value);
        }

        public InventorParameter(Parameter parameter)
        {
            _parameter = parameter;

            SetUnitTypes();
        }

        private void SetUnitTypes()
        {
            string formattedUnits = Units.ToUpper();

            switch (formattedUnits)
            {
                case "IN":
                    LengthUnit = LengthUnits.In;
                    UnitType = UnitTypes.Length;
                    break;
                case "MM":
                    LengthUnit = LengthUnits.MM;
                    UnitType = UnitTypes.Length;
                    break;
                case "M":
                    LengthUnit = LengthUnits.M;
                    UnitType = UnitTypes.Length;
                    break;
                case "RAD":
                    AngularUnit = AngularUnits.Radians;
                    UnitType = UnitTypes.Angular;
                    break;
                case "RADIAN":
                    AngularUnit = AngularUnits.Radians;
                    UnitType = UnitTypes.Angular;
                    break;
                case "DEG":
                    AngularUnit = AngularUnits.Degrees;
                    UnitType = UnitTypes.Angular;
                    break;
                case "DEGREES":
                    AngularUnit = AngularUnits.Degrees;
                    UnitType = UnitTypes.Angular;
                    break;
                case "UL":
                case "UNITLESS":
                    UnitType = UnitTypes.Unitless;
                    break;
                case "TEXT":
                    UnitType = UnitTypes.Text;
                    break;
            }
        }

        public void Dispose()
        {
            if (_parameter != null)
            {
                Marshal.ReleaseComObject(_parameter);
            }
        }
    }
}
