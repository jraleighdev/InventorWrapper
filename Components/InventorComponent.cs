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
    public class InventorComponent : IDisposable
    {
        private InventorDocument _document;

        public ComponentOccurrence _component;

        public string Name => _component.Name;

        public bool Visible
        {
            get => _component.Visible;
            set => _component.Visible = value;
        }

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

        public bool IsPatternElement => _component.IsPatternElement;

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
