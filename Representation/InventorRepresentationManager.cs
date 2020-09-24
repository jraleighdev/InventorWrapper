using Inventor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Representation
{
    public class InventorRepresentationManager
    {
        public List<InventorDesignViewRep> InventorDesignViewReps { get; set; }

        private RepresentationsManager _representationsManager;

        public InventorRepresentationManager(RepresentationsManager representationsManager)
        {
            _representationsManager = representationsManager;

            foreach (DesignViewRepresentation r in _representationsManager.DesignViewRepresentations)
            {
               
            }
        }

        public void ActivateLevelOfDetail(string name) => _representationsManager.LevelOfDetailRepresentations[name].Activate(true);

        public void ActivateDesignView(string name) => _representationsManager.DesignViewRepresentations[name].Activate();

        public string ActiveDesignView => _representationsManager.ActiveDesignViewRepresentation.Name;

        public List<string> GetDesignReps()
        {
            var reps = new List<string>();

            foreach (DesignViewRepresentation r in _representationsManager.DesignViewRepresentations)
            {
                reps.Add(r.Name);
            }

            return reps;
        }
         

    }
}
