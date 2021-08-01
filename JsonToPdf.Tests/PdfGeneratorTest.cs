using JsonToPdf.Model.Entities;
using JsonToPdf.Model.Enums;
using JsonToPdf.Module.JsonProcessing;
using JsonToPdf.Module.PdfProcessing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JsonToPdf.Tests
{
    [TestClass]
    public class PdfGeneratorTest
    {
        private readonly IJsonProcessing _jsonProcessing;
        private readonly IPdfGenerator _pdfGenerator;

        public PdfGeneratorTest(IJsonProcessing jsonProcessing, IPdfGenerator pdfGenerator)
        {

            _jsonProcessing = jsonProcessing;
            _pdfGenerator = pdfGenerator;
        }

        [TestMethod]
        public void Generate_Pdf()
        {

            Guid id = Guid.Parse("3fa85f64-5717-4562-b3fc-2c963f66afa6");
            string number = "123";
            DocumentType documentType = 0;
            string actName = "Test";

            _pdfGenerator.GeneratePdf(id, number, documentType, actName);
        }
    }
}
