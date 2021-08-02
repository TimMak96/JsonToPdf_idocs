using JsonToPdf.Model.Entities;
using JsonToPdf.Module.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToPdf.Module.JsonProcessing
{
    /// <summary>
    /// Интерфейс для 
    /// </summary>
    public interface IJsonProcessing
    {
        Boolean DocumentTypeDefinition(BaseDocument document);
        BaseDocumentEntity ProcessingJsonDocument(string JsonString);

    }
}
