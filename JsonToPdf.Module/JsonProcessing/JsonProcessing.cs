using JsonToPdf.Model.Entities;
using JsonToPdf.Module.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToPdf.Module.JsonProcessing
{
    /// <summary>
    /// Класс для определения типа документа
    /// </summary>
    public class JsonProcessing : IJsonProcessing
    {
        /// <summary>
        /// Метод определения типа документа по общему классу
        /// </summary>
        /// <param name="entity">Базовая сущность</param>
        /// <returns></returns>
        public bool DocumentTypeDefinition(BaseDocument entity)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Обработка документа
        /// </summary>
        /// <param name="JsonString">Получаемый Json</param>
        /// <returns></returns>
        public BaseDocumentEntity ProcessingJsonDocument(string JsonString)
        {
            throw new NotImplementedException();
        }
    }
}
