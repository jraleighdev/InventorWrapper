﻿using Inventor;
using InventorWrapper.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.String;

namespace InventorWrapper.IProps
{
    /// <summary>
    /// General document properties and custom properties
    /// </summary>
    public class InventorProperties
    {
        /// <summary>
        /// Name of the Project tab in inventor
        /// </summary>
        public const string ProjectTab = "Design Tracking Properties";

        private PropertySets _propertySets;

        private List<Tuple<string, string>> _customProperties;

        public InventorProperties(PropertySets propertySets)
        {
            _propertySets = propertySets;
        }

        /// <summary>
        /// Custom properties for the document
        /// </summary>
        public List<Tuple<string, string>> CustomProperties
        {
            get
            {
                var customProperties = _propertySets[IpropertyEnum.Custom.GetCategory()];

                if (_customProperties == null)
                {
                    _customProperties = (from Property customProperty 
                        in customProperties select ( new Tuple<string, string>(customProperty.Name, customProperty.Value as string))).ToList();
                }

                return _customProperties;
            }
        }

        /// <summary>
        /// Checks if the property exists
        /// </summary>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public bool PropertyExists(string propertyName) => CustomProperties.Count > 0 &&
            CustomProperties.Any(prop => prop.Item1.ToUpper() == propertyName.ToUpper());

        /// <summary>
        /// Gets the given iproperty if the custom is selected give the name
        /// </summary>
        /// <param name="ipropertyEnum"></param>
        /// <param name="customName"></param>
        /// <returns></returns>
        public string GetPropertyValue(IpropertyEnum ipropertyEnum, string customName = "")
        {
            var property = ipropertyEnum == IpropertyEnum.Custom ? 
                PropertyExists(customName) ? _propertySets[ipropertyEnum.GetCategory()][customName] : null :
                _propertySets[ipropertyEnum.GetCategory()][ipropertyEnum.GetDescription()];

            if (property == null)
            {
                return "";
            }

            return property.Value as string;
        }

        /// <summary>
        /// Sets the value of the given property
        /// </summary>
        /// <param name="ipropertyEnum"></param>
        /// <param name="value"></param>
        /// <param name="customName"></param>
        /// <exception cref="Exception"></exception>
        public void SetPropertyValue(IpropertyEnum ipropertyEnum, string value, string customName)
        {
            Property property = null;

            if (ipropertyEnum == IpropertyEnum.Custom)
            {
                var customProperties = _propertySets[ipropertyEnum.GetCategory()];

                foreach (Property p in customProperties)
                {
                    if (p.Name == customName)
                    {
                        property = p;
                        break;
                    }
                }
            }
            else
            {
                property = _propertySets[ipropertyEnum.GetCategory()][ipropertyEnum == IpropertyEnum.Custom ? customName : ipropertyEnum.GetDescription()];
            }

            if (property == null)
            {
                if (ipropertyEnum == IpropertyEnum.Custom)
                {
                    _propertySets[ipropertyEnum.GetCategory()].Add(value, customName);
                }
                else
                {
                    throw new Exception($"Could not set {(ipropertyEnum == IpropertyEnum.Custom ? customName : ipropertyEnum.GetDescription())}");
                }
            }
            else
            {
                property.Value = value;
            }
        }
    }
}
