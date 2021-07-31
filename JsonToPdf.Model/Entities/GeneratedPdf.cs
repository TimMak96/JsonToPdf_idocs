using JsonToPdf.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToPdf.Model.Entities
{
    [Table("GeneratedPdfs")]
    public class GeneratedPdf : BaseDocumentEntity
    {
        [Column(TypeName = "VARCHAR(255)")]
        public string PdfName { get; set; }
        public Status PdfStatus { get; set; }
    }
}
