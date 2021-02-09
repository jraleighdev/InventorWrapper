using Inventor;
using InventorWrapper.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Components
{
    /// <summary>
    /// Inventor component reference represents a component in hte model
    /// </summary>
    public class InventorComponent : IDisposable
    {
        /// <summary>
        /// Document reference of the component
        /// </summary>
        private InventorDocument _document;

        /// <summary>
        /// Interop reference for the component
        /// </summary>
        public ComponentOccurrence _component;

        /// <summary>
        /// Name of the component
        /// </summary>
        public string Name => _component.Name;

        /// <summary>
        /// Gets and sets the visibility of the component
        /// </summary>
        public bool Visible
        {
            get => _component.Visible;
            set => _component.Visible = value;
        }

        /// <summary>
        /// Gets and sets the suppression status of the component
        /// </summary>
        public bool Suppressed
        {
            get => _component.Suppressed;

            set
            {
                if (value)
                {
                    if (!_component.Suppressed)
                    {
                        _component.Suppress();
                    }
                }
                else
                {
                    if (_component.Suppressed)
                    {
                        _component.Unsuppress();
                    }
                }
            }
        }

        /// <summary>
        /// If the component is a pattern element
        /// </summary>
        public bool IsPatternElement => _component.IsPatternElement;

        /// <summary>
        /// Inventor document reference
        /// </summary>
        public InventorDocument Document
        { 
            get
            {
                if (_document == null && !Suppressed)
                {
                    var doc = _component.Definition.Document as Document;

                    if (doc != null)
                    {
                        _document = new InventorDocument(doc);
                    }
                }

                return _document;
            }
        }

        public InventorComponent(ComponentOccurrence component)
        {
            _component = component;
        }

        public void Dispose()
        {
            if (_component != null)
            {
                Marshal.ReleaseComObject(_component);
            }
        }
    }
}
