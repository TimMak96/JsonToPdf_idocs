using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToPdf.Model.Entities
{
    /// <summary>
    /// Накладная
    /// </summary>
    [Table("ConsignmentsNotes")]
    public class ConsignmentNoteEntity : BaseDocumentEntity
    {
        /// <summary>
        /// ИД товара
        /// </summary>
        [Column(TypeName = "decimal(32, 0)")]
        public decimal ProdictId { get; set; }
    }
}
