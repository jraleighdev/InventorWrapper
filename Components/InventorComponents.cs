using Inventor;
using InventorWrapper.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Components
{
    /// <summary>
    /// Collection of inventor component
    /// </summary>
    public class InventorComponents : List<InventorComponent>
    {
        private InventorAssemblyDocument _adoc;

        /// <summary>
        /// Sets the reference to the assembly document and if recursion is true will grab all the child occurrences of sub assemblies
        /// </summary>
        /// <param name="adoc"></param>
        /// <param name="recurse"></param>
        public InventorComponents(InventorAssemblyDocument adoc, bool recurse = false)
        {
            _adoc = adoc;

            GetComponents(_adoc._adef.Occurrences, recurse);
        }

        /// <summary>
        /// Sets the status of component in the assembly by reference
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Deletes the component by name
        /// </summary>
        /// <param name="name"></param>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Deletes all components in the by document reference
        /// </summary>
        /// <param name="name"></param>
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

        /// <summary>
        /// Gets the status of component in the assembly
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Gets all the components in the active assembly
        /// </summary>
        /// <param name="occurrences"></param>
        /// <param name="recurse"></param>
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
