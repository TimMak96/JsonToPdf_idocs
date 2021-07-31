using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToPdf.Model.Entities
{
    [Table("Contracts")]
    public class Contract : BaseDocumentEntity
    {
        public DateTime DateOfContract { get; set; }
    }
}
