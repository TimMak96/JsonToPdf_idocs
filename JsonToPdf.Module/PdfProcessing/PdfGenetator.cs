using JsonToPdf.Model.Entities;
using JsonToPdf.Module.Models;
using Newtonsoft.Json;
using System.IO;
using Aspose.Words;
using Aspose.Words.Drawing;
using Aspose.Words.Reporting;
using JsonToPdf.Model.Enums;
using System;

namespace JsonToPdf.Module.PdfProcessing
{
    /// <summary>
    /// Генерация PDF
    /// </summary>
    public class PdfGenetator : IPdfGenerator
    {
        /// <summary>
        /// Метод генерации Пдф для акта
        /// </summary>
        /// <param name="id"></param>
        /// <param name="number"></param>
        /// <param name="documentType"></param>
        /// <param name="actName"></param>
        public void GeneratePdf(Guid id, string number, DocumentType documentType, string actName)
        {
            //"3fa85f64-5717-4562-b3fc-2c963f66afa6", "123", 0, "Test"
            Document doc = new Document("template.docx");
            ActOfReconciliation dataSource = new ActOfReconciliation(id, number, documentType, actName);
            ReportingEngine engine = new ReportingEngine();
            engine.BuildReport(doc, dataSource, "actOfReconciliationEntity");
            doc.Save("word.docx");
        }
    }
}
