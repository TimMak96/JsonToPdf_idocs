using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToPdf.Model.Entities
{
    /// <summary>
    /// Акт сверки
    /// </summary>
    [Table("ActsOfReconciliation")]
    public class ActOfReconciliationEntity : BaseDocumentEntity
    {
        /// <summary>
        /// Наименование акта сверки
        /// </summary>
        [Column(TypeName = "VARCHAR(255)")]
        public string ActName { get; set; }
    }
}
