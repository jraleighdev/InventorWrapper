using Inventor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Representation
{
    /// <summary>
    /// Manages the representation in the active document
    /// </summary>
    public class InventorRepresentationManager
    {
        private RepresentationsManager _representationsManager;

        public InventorRepresentationManager(RepresentationsManager representationsManager)
        {
            _representationsManager = representationsManager;
        }

        /// <summary>
        /// Activates the level of detail in the model
        /// </summary>
        /// <param name="name"></param>
        public void ActivateLevelOfDetail(string name) => _representationsManager.LevelOfDetailRepresentations[name].Activate(true);

        /// <summary>
        /// Gets the active level of detail in the model
        /// </summary>
        public string ActiveLevelOfDetail => _representationsManager.ActiveLevelOfDetailRepresentation.Name;

        /// <summary>
        /// Activate the design view in the model
        /// </summary>
        /// <param name="name"></param>
        public void ActivateDesignView(string name) => _representationsManager.DesignViewRepresentations[name].Activate();

        /// <summary>
        /// Gets the Active design view
        /// </summary>
        public string ActiveDesignView => _representationsManager.ActiveDesignViewRepresentation.Name;

        /// <summary>
        /// Get the design view reps in the active model
        /// </summary>
        /// <returns></returns>
        public List<string> GetDesignReps()
        {
            return (from DesignViewRepresentation r in _representationsManager.DesignViewRepresentations select r.Name).ToList();
        }

        /// <summary>
        /// Gets the level details in the active model
        /// </summary>
        /// <returns></returns>
        public List<string> GetLevelDetails()
        {
            return (from LevelOfDetailRepresentation r in _representationsManager.LevelOfDetailRepresentations
                select r.Name).ToList();
        }
    }
}
