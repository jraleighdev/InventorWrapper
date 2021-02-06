using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Documents
{
    /// <summary>
    /// Helps retrieve documents from the active document
    /// </summary>
    public class DocumentHelper
    {
        /// <summary>
        /// Finds a document in the active assembly
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static InventorDocument GetDocument(string name)
        {
            // Set an initial value to return
            InventorDocument documentToReturn = null;

            if (InventorApplication.ActiveDocument == null)
            {
                throw new Exception("Must have an open document");
            }

            // if an assembly document then parse the document
            if (InventorApplication.ActiveDocument.IsAssemblyDoc)
            {
                var adoc = InventorApplication.ActiveDocument.GetAssemblyDocument();

                // if the active document matches the name then return the active
                if (name == System.IO.Path.GetFileNameWithoutExtension(adoc.Name))
                {
                    documentToReturn = InventorApplication.ActiveDocument;
                }
                else
                {
                    // Search the document in the referenced documents within the assembly
                    documentToReturn = adoc.GetReferencedDocument(name);
                }
            }
            // if it is a part doc then return the active document
            else if (InventorApplication.ActiveDocument.IsPartDoc)
            {
                documentToReturn = InventorApplication.ActiveDocument;
            }

            return documentToReturn;
        }
    }
}
