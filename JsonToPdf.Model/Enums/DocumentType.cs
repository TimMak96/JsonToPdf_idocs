using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToPdf.Model.Enums
{
    /// <summary>
    /// Возможные типы документов для обработки
    /// </summary>
    public enum DocumentType
    {
        ConsigmentNote = 0,
        Contract = 1,
        ActOfReconciliation = 2
    }
}
