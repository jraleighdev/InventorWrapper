using Inventor;
using InventorWrapper.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.CopyTools
{
    public class CopyHelpers
    {
        public static void ReplaceReferences(InventorDocument document, List<Tuple<string, string>> paths, List<string> skip = null)
        {
            Recurse(document._document.File.ReferencedFileDescriptors, paths);
        }

        private static void Recurse(FileDescriptorsEnumerator refs, List<Tuple<string, string>> paths, List<string> skip = null)
        {
            foreach (FileDescriptor r in refs)
            {
                var path = r.FullFileName;

                if (skip != null && skip.Count > 0)
                {
                    if (skip.Any(x => r.FullFileName.ToUpper().Contains(x.ToUpper())))
                    {
                        continue;
                    }
                }

                var refPath = paths.FirstOrDefault(x => x.Item1.ToUpper() == path.ToUpper());

                if (refPath == null) continue;

                r.ReplaceReference(refPath.Item2);

                if (r.ReferencedFileType == FileTypeEnum.kAssemblyFileType)
                {
                    Inventor.File file = r.ReferencedFile;

                    Recurse(file.ReferencedFileDescriptors, paths, skip);
                }
            }
        }
    }
}
