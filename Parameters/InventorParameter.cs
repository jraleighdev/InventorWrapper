﻿using Inventor;
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

        public dynamic Value
        {
            get => _parameter.Value;

            set => _parameter.Value = value;
        }

        public dynamic ConvertedValue
        {
            get
            {
                if (UnitType == UnitTypes.Length)
                {
                    return UnitManager.UnitsFromInventor((double)_parameter.Value);
                }
                else if (UnitType == UnitTypes.Angular)
                {
                    return UnitManager.UnitsFromInventor((double)_parameter.Value, UnitTypes.Angular);
                }

                return _parameter.Value;
            }
        }

        public bool IsUser => _parameter.ParameterType == ParameterTypeEnum.kUserParameter;

        public string Expression
        {
            get => _parameter.Expression;

            set => _parameter.Expression = value;
        }

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
