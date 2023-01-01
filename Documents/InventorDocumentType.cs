using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorWrapper.Documents
{
    public enum InventorDocumentType
    {
        Unknown = 12289,
        Part = 12290,
        Assembly = 12291,
        Drawing = 12292,
        Presentation = 12293,
        DesignElement = 12294,
        ForeignModel = 12295,
        SATFile = 12296,
        No = 12297,
        NestingDocument = 12298
    }
}
