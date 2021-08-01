using JsonToPdf.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToPdf.Model.Entities
{
    /// <summary>
    /// Сущность, содержащая в себе информацию по сгенерированным PDF-файлам
    /// </summary>
    [Table("GeneratedPdfs")]
    public class GeneratedPdfEntity : BaseDocumentEntity
    {
        /// <summary>
        /// Наименование PDF-файла
        /// </summary>
        [Column(TypeName = "VARCHAR(255)")]
        public string PdfName { get; set; }
        /// <summary>
        /// Статус генерируемого PDF-файла 
        /// </summary>
        public Status PdfStatus { get; set; }
    }
}
