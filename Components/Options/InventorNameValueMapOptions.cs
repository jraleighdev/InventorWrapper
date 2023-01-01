using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Components.Options
{
    public  class InventorNameValueMapOptions
    {
        public InventorNameValueMapOptions(string name, object value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; set; }

        public object Value { get; set; }
    }
}
