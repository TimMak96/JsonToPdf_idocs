using JsonToPdf.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToPdf.Model.Entities
{
    public abstract class BaseDocumentEntity
    {
        public Guid Id { get; set; }
        [Column(TypeName = "VARCHAR(255)")]
        public string Number { get; set; }
       
    }
}
