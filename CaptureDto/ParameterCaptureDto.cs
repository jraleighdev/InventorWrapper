using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.CaptureDto
{
    public class ParameterCaptureDto
    {
        public string Name { get; set; }

        public bool User { get; set; }

        public dynamic Value { get; set; }

        public ParameterCaptureDto(string name, bool user, dynamic value)
        {
            Name = name;
            User = user;
            Value = value;
        }
    }
}
