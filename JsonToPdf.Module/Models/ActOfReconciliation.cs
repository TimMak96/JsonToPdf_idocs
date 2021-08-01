using JsonToPdf.Model.Entities;
using JsonToPdf.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToPdf.Module.Models
{
    /// <summary>
    /// Акт сверки
    /// </summary>
    public class ActOfReconciliation
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
        /// <summary>
        /// Наименование акта сверки
        /// </summary>
        public string ActName { get; set; }
        /// <summary>
        /// Конструктор Акта сверки
        /// </summary>
        /// <param name="actOfReconciliationEntity">Сущность Акта сверки</param>
        public ActOfReconciliation(Guid _id, string _number, DocumentType _documentType, string _actName)
        {
            _id = Id;
            _number = Number;
            _documentType = DocumentType;
            _actName = ActName;
        }

    }
}
