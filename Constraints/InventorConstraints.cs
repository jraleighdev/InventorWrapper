using Inventor;
using InventorWrapper.Documents;
using InventorWrapper.Geometry;
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

        public void AddMateConstraint(InventorProxy proxyOne, InventorProxy proxyTwo, double offset)
        {
            _adoc._adef.Constraints.AddMateConstraint(proxyOne._reference, proxyTwo._reference, offset);
        }

        public void AddMateConstraint(InventorWorkPlane plane, InventorProxy proxyTwo, double offset)
        {
            _adoc._adef.Constraints.AddMateConstraint(plane._workPlane, proxyTwo._reference, offset);
        }

        public void AddFlushConstraint(InventorWorkPlane plane, InventorProxy proxyTwo, double offset)
        {
            _adoc._adef.Constraints.AddFlushConstraint(plane._workPlane, proxyTwo._reference, offset);
        }

        public void AddFlushConstraint(InventorProxy proxyOne, InventorProxy proxyTwo, double offset)
        {
            _adoc._adef.Constraints.AddFlushConstraint(proxyOne._reference, proxyTwo._reference, offset);
        }

        public void Delete(string name)
        {
            try
            {
                _adoc._adef.Constraints[name].Delete();
            }
            catch (Exception ex)
            {
                throw new Exception($"Could not delete constraint {name}", ex);
            }
        }

        public void DeleteAll()
        {
            foreach (AssemblyConstraint constraint in _adoc._adef.Constraints)
            {
                constraint.Delete();
            }
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
