using JsonToPdf.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToPdf.Model.Entities
{
    /// <summary>
    /// Общий класс, содержащий в себе пересекающиеся поля дочерних классов
    /// </summary>
    public abstract class BaseDocumentEntity
    {
        /// <summary>
        /// Уникальный индификатор документа
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Номер документа
        /// </summary>
        [Column(TypeName = "VARCHAR(255)")]
        public string Number { get; set; }
        /// <summary>
        /// Тип документа
        /// </summary>
        public DocumentType DocumentType { get; set; }
    }
}
