using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToPdf.Model.Entities
{
    /// <summary>
    /// Договор
    /// </summary>
    [Table("Contracts")]
    public class ContractEntity : BaseDocumentEntity
    {
        /// <summary>
        /// Дата заключения договора
        /// </summary>
        public DateTime DateOfContract { get; set; }
    }
}
