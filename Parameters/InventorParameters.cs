using Inventor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Parameters
{
    public class InventorParameters : List<InventorParameter>
    {
        private Inventor.Parameters _parameters;

        public InventorParameters(Inventor.Parameters parameters)
        {
            _parameters = parameters;

            foreach(Parameter p in parameters)
            {
                Add(new InventorParameter(p));
            }
        }

        public InventorParameter GetParameter(string name)
        {
            return this.FirstOrDefault(x => x.Name == name);
        }

        /// <summary>
        /// Returns true or false if the parameter is found
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SetParameter(string name, dynamic value)
        {
            var parameter = this.FirstOrDefault(x => x.Name == name);

            if (parameter != null)
            {
                parameter.Value = value;
            }

            return parameter != null;
        }
    }
}
