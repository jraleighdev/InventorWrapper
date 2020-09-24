using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Documents
{
    public class DocumentHelper
    {
        public static InventorDocument GetDocument(string name)
        {
            InventorDocument documentToReturn = null;

            if (InventorApplication.ActiveDocument == null)
            {
                throw new Exception("Must have an open document");
            }

            if (InventorApplication.ActiveDocument.IsAssemblyDoc)
            {
                var adoc = InventorApplication.ActiveDocument.GetAssemblyDocument();

                if (name == System.IO.Path.GetFileNameWithoutExtension(adoc.Name))
                {
                    documentToReturn = InventorApplication.ActiveDocument;
                }
                else
                {
                    documentToReturn = adoc.GetReferencedDocument(name);
                }
            }
            else if (InventorApplication.ActiveDocument.IsPartDoc)
            {
                documentToReturn = InventorApplication.ActiveDocument;
            }

            return documentToReturn;
        }
    }
}
