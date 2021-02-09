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
    /// <summary>
    /// Manages assembly constraints and statuses
    /// </summary>
    public class InventorConstraints
    {
        private InventorAssemblyDocument _adoc;

        private List<string> _constraintNames;

        public InventorConstraints(InventorAssemblyDocument adoc)
        {
            _adoc = adoc;
        }

        /// <summary>
        /// Sets the status of named constraint
        /// </summary>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Gets a list of all the constraints
        /// </summary>
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
