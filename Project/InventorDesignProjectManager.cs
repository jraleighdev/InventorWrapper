using Inventor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Project
{
    public class InventorDesignProjectManager : IDisposable
    {
        private List<InventorDesignProject> _projects;

        public DesignProjectManager _designProjectManager;

        public List<Exception> Errors { get; private set; } = new List<Exception>();

        public InventorDesignProject ActiveProject
        {
            get => new InventorDesignProject(_designProjectManager.ActiveDesignProject);       
        }

        public string ResolveFile(string sourcePath, string fileName)
        {
            return _designProjectManager.ResolveFile(sourcePath, fileName);
        }

        public List<InventorDesignProject> DesignProjects
        {
            get
            {
                if (_projects == null)
                {
                    _projects = new List<InventorDesignProject>();

                    foreach (DesignProject d in _designProjectManager.DesignProjects)
                    {
                        _projects.Add(new InventorDesignProject(d));
                    }
                }

                return _projects;
            }
        }

        public InventorDesignProjectManager(DesignProjectManager designProjectManager)
        {
            _designProjectManager = designProjectManager;
        }

        public void Dispose()
        {
            if (_designProjectManager != null)
            {
                Marshal.ReleaseComObject(_designProjectManager);
                _designProjectManager = null;

                ActiveProject?.Dispose();

                try
                {
                    if (_projects != null && _projects.Count > 0)
                    {
                        foreach (var project in _projects)
                        {
                            project.Dispose();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Errors.Add(ex);
                }
            }
        }
    }
}
