using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using JsonToPdf.Module.JsonProcessing;
using JsonToPdf.Model.Entities;
using JsonToPdf.Module.Models;
using Newtonsoft.Json;
using System.IO;
using JsonToPdf.Module.PdfProcessing;
using System;
using JsonToPdf.Model.Enums;

namespace JsonToPdf.Controllers
{

    public class BaseController : Controller
    {
        private readonly IJsonProcessing _jsonProcessing;
        private readonly IPdfGenerator _pdfGenerator;
        
        public BaseController(IJsonProcessing jsonProcessing, IPdfGenerator pdfGenerator)
        {

            _jsonProcessing = jsonProcessing;
            _pdfGenerator = pdfGenerator;
        }

        /// <summary>
        /// Метод Преобразования Json в PDF
        /// </summary>
        /// <param name="value">Входные параметры документа</param>
        /// <returns>Id сформированного документа</returns>

        [HttpPost("jsontopdf")]
        public async Task <IActionResult> JsonToPdf([FromBody] BaseDocument value)
        {
            //_interdace1.GeneratePdf();


            //var stream = HttpContext.Current.Request.InputStream;
            return Ok(value.Id);
        }

    }
}
