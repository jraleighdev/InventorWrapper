using Inventor;
using InventorWrapper.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Components
{
    public class InventorComponents : List<InventorComponent>
    {
        private InventorAssemblyDocument _adoc;

        public InventorComponents(InventorAssemblyDocument adoc, bool recurse = false)
        {
            _adoc = adoc;

            GetComponents(_adoc._adef.Occurrences, recurse);
        }

        public void SetComponentStatus(string name, bool value)
        {
            try
            {
                ComponentOccurrence occ = _adoc._adef.Occurrences.ItemByName[name];

                if (value)
                {
                    occ.BOMStructure = BOMStructureEnum.kReferenceBOMStructure;
                    occ.Suppress();
                }
                else
                {
                    occ.Unsuppress();
                    occ.BOMStructure = BOMStructureEnum.kDefaultBOMStructure;
                }
            }
            catch 
            {
                throw new Exception("Could not find component " + name);
            }
        }

        public void DeleteComponent(string name)
        {
            var set = false;

            foreach (ComponentOccurrence c in _adoc._adef.Occurrences)
            {
                if (c.Name == name)
                {
                    c.Delete();
                    set = true;
                    break;
                }
            }

            if (!set)
            {
                throw new Exception($"Could not find component {name} in document {_adoc.Name}");
            }
        }

        public void DeleteComponents(string name)
        {
            foreach (ComponentOccurrence c in _adoc._adef.Occurrences)
            {
                var suppressed = false;

                if (c.Suppressed)
                {
                    suppressed = true;
                    c.Unsuppress();
                }

                if (System.IO.Path.GetFileNameWithoutExtension(((Document)c.Definition.Document).FullFileName) == name)
                {
                    if (c.IsPatternElement)
                    {
                        // TODO Look into supporting pattern elements
                        continue;
                    }
                    else
                    {
                        c.Delete();
                    }
                }
                else
                {
                    if (suppressed)
                    {
                        c.Suppress();
                    }
                }
            }
        }

        public bool GetComponentStatus(string name)
        {
            try
            {
                ComponentOccurrence occ = _adoc._adef.Occurrences.ItemByName[name];

                return occ.Suppressed;
            }
            catch
            {
                throw new Exception("Could not find component " + name);
            }
        }

        public void GetComponents(ComponentOccurrences occurrences, bool recurse)
        {
            foreach (ComponentOccurrence c in occurrences)
            {
                Add(new InventorComponent(c));

                if (recurse)
                {
                    if (c.Definition.Type == ObjectTypeEnum.kAssemblyComponentDefinitionObject || c.Definition.Type == ObjectTypeEnum.kWeldmentComponentDefinitionObject)
                    {
                        GetComponents(occurrences, recurse);
                    }
                }
            }
        }
    }
}
