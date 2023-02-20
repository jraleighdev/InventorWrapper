using Inventor;
using InventorWrapper.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace InventorWrapper.Project
{
    public class InventorDesignProject : IDisposable
    {
        private List<InventorProjectPath> _libraryPaths;

        public DesignProject _designProject;

        public InventorDesignProject(DesignProject design)
        {
            _designProject = design;
        }

        public InventorObjectTypes Type => (InventorObjectTypes)_designProject.Type;

        public string Name => _designProject.Name;

        public string FullFileName => _designProject.FullFileName;

        public string TemplatesPath => _designProject.TemplatesPath;

        public string WorkSpacePath => _designProject.WorkspacePath;

        public List<InventorProjectPath> LibraryPaths
        {
            get
            {
                if (_libraryPaths == null)
                {
                    _libraryPaths = new List<InventorProjectPath>();

                    foreach (ProjectPath l in _designProject.LibraryPaths)
                    {
                        _libraryPaths.Add(new InventorProjectPath(l, this));
                    }
                }

                return _libraryPaths;
            }
        }

        public void Dispose()
        {
            if (_designProject!= null)
            {
                Marshal.ReleaseComObject(_designProject);
                _designProject = null;
            }
        }
    }
}
