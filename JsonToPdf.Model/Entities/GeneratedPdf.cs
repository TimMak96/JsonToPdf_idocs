using JsonToPdf.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToPdf.Model.Entities
{
    public class GeneratedPdf : BaseEntity
    {
        public string PdfName { get; set; }
        public Status PdfStatus { get; set; }
    }
}
