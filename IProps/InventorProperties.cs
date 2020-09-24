using Inventor;
using InventorWrapper.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.IProps
{
    public class InventorProperties
    {
        public const string ProjectTab = "Design Tracking Properties";

        private PropertySets _propertySets;

        public InventorProperties(PropertySets propertySets)
        {
            _propertySets = propertySets;
        }

        /// <summary>
        /// Gets the given iproperty if the custom is selected give the name
        /// </summary>
        /// <param name="ipropertyEnum"></param>
        /// <param name="customName"></param>
        /// <returns></returns>
        public string GetPropertyValue(IpropertyEnum ipropertyEnum, string customName = "")
        {
            var property = _propertySets[ipropertyEnum.GetCategory()][ipropertyEnum == IpropertyEnum.Custom ? customName : ipropertyEnum.GetDescription()];

            if (property == null)
            {
                return "";
            }

            return property.Value as string;
        }

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
