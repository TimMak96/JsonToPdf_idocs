using JsonToPdf.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsonToPdf.Module.Models
{
    // <summary>
    /// Модель, содержащая в себе пересекающиеся поля дочерних классов
    /// </summary>
    public class BaseDocument
    {
     
        /// <summary>
        /// Уникальный индификатор документа
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Номер документа
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// Тип документа
        /// </summary>
        public DocumentType DocumentType { get; set; }

    }
}
