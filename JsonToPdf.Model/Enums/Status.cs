using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToPdf.Model.Enums
{
    /// <summary>
    /// Возможные статусы PDF-файла
    /// </summary>
    public enum Status
    {
        InitializeDocument = 0,
        AcceptedDocument = 1,
        ErrorDocument = 2
    }
}
