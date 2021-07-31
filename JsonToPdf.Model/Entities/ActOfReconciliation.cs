using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToPdf.Model.Entities
{
    [Table("ActsOfReconciliation")]
    public class ActOfReconciliation : BaseDocumentEntity
    {
        [Column(TypeName = "VARCHAR(255)")]
        public string ActName { get; set; }
    }
}
