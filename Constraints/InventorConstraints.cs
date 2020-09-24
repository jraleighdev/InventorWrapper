using Inventor;
using InventorWrapper.Documents;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Constraints
{
    public class InventorConstraints
    {
        private InventorAssemblyDocument _adoc;

        private List<string> _constraintNames;

        public InventorConstraints(InventorAssemblyDocument adoc)
        {
            _adoc = adoc;
        }

        public bool SetConstraintStatus(string name, bool status)
        {
            var value = false;

            foreach (AssemblyConstraint c in _adoc._adef.Constraints)
            {
                if (c.Name == name)
                {
                    c.Suppressed = status;
                    value = true;
                    break;
                }
            }

            return value;
        }

        public List<string> ConstraintNames
        {
            get
            {
                if (_constraintNames == null)
                {
                    _constraintNames = new List<string>();

                    foreach (AssemblyConstraint c in _adoc._adef.Constraints)
                    {
                        _constraintNames.Add(c.Name);
                    }
                }

                return _constraintNames;
            }
        }
    }
}
