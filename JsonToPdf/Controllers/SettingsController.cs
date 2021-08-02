using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JsonToPdf.Controllers
{
    /// <summary>
    /// Контроллер для подтягивания настроек из таблиц
    /// </summary>
    public class SettingsController
    {
        /// <summary>
        /// Метод для логирования процессов
        /// </summary>
        /// <param name="logFolder">Путь к файлу</param>
        /// <param name="str">Сообщение</param>
        public static void DebugLog(String logFolder, String str)
        {
            try
            {
                /* IF COMMENTED - DO NOT REMOVE */
                if (!String.IsNullOrEmpty(logFolder))
                {
                    //var file = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + "\\ESFINTEGRA_LOG.txt";
                    var file = logFolder + "\\JsonToPDF.txt";
                    using (var respFile = new StreamWriter(file, true))
                    {
                        respFile.WriteLine(String.Format("{0:dd MMM yyyy hh:mm:ss}: ", DateTime.Now) + str);
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO
            }
        }
    }
}
