using Inventor;
using InventorWrapper.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Project
{
    public class InventorProjectPath : IDisposable
    {
        public ProjectPath _projectPath;

        public string Name => _projectPath.Name;

        public InventorDesignProject Parent { get; private set; }

        public InventorObjectTypes Type => (InventorObjectTypes)_projectPath.Type;

        public string Path => _projectPath.Path;

        public InventorProjectPath(ProjectPath projectPath, InventorDesignProject parent)
        {
            _projectPath = projectPath;
            Parent = parent;
        }

        public void Dispose()
        {
            if (_projectPath != null )
            {
                Marshal.ReleaseComObject(_projectPath);
                _projectPath = null;
            }
        }
    }
}
