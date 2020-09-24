using Inventor;
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
