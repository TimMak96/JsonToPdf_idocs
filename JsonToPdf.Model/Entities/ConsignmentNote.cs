using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToPdf.Model.Entities
{
    [Table("ConsignmentsNotes")]
    public class ConsignmentNote : BaseDocumentEntity
    {
        [Column(TypeName = "decimal(32, 0)")]
        public decimal ProdictId { get; set; }
    }
}
