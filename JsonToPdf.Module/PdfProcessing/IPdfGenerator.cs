using JsonToPdf.Model.Entities;
using JsonToPdf.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToPdf.Module.PdfProcessing
{
    public interface IPdfGenerator
    {
        public void GeneratePdf(Guid id, string number, DocumentType documentType, string actName);
    }
}
