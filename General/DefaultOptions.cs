using InventorWrapper.Components.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.General
{
    public static class DefaultOptions
    {
        public const string LevelOfDetailRepresentation = "LevelOfDetailRepresentation";

        public const string ILogic = "Ilogic";

        public static List<InventorNameValueMapOptions> DefaultNameValueOptions => new List<InventorNameValueMapOptions>
                {
                    new InventorNameValueMapOptions(LevelOfDetailRepresentation, ILogic)
                };
    }
}
