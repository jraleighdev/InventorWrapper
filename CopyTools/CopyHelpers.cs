using Inventor;
using InventorWrapper.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.CopyTools
{
    /// <summary>
    /// Methods for simplifying copy inventor assembly models
    /// </summary>
    public class CopyHelpers
    {
        /// <summary>
        /// Replace the references in the document
        /// </summary>
        /// <param name="document"></param>
        /// <param name="referenceData"></param>
        /// <param name="skip"></param>
        public static void ReplaceReferences(InventorDocument document, List<ReferenceDto> referenceData, List<string> skip = null)
        {
            Recurse(document._document.File.ReferencedFileDescriptors, referenceData);
        }

        /// <summary>
        /// Recursive method that will replace all the references
        /// In the assembly document and all the child assembly documents
        /// </summary>
        /// <param name="refs"></param>
        /// <param name="referenceData"></param>
        /// <param name="skip"></param>
        private static void Recurse(FileDescriptorsEnumerator refs, List<ReferenceDto> referenceData, List<string> skip = null)
        {
            // Loop through the references in the document
            foreach (FileDescriptor r in refs)
            {
                // get the full path of the file
                var path = r.FullFileName;

                // If any of the files are in skip then continue
                if (skip != null && skip.Count > 0)
                {
                    if (skip.Any(x => r.FullFileName.ToUpper().Contains(x.ToUpper())))
                    {
                        continue;
                    }
                }

                // Get the file name that matches the file ref
                var refPath = referenceData.FirstOrDefault(x => x.OriginalReference.ToUpper() == path.ToUpper());

                // if not found then continue
                if (refPath == null) continue;

                // Replace the reference with item 2
                r.ReplaceReference(refPath.NewReference);

                // If the document is an assembly document
                if (r.ReferencedFileType == FileTypeEnum.kAssemblyFileType)
                {
                    // Get the reference file
                    Inventor.File file = r.ReferencedFile;

                    // Recurse through the sub assembly files
                    Recurse(file.ReferencedFileDescriptors, referenceData, skip);
                }
            }
        }
    }
}
