using JsonToPdf.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToPdf.Model.Repositories
{
    /// <summary>
    /// Репозиторий для работы с БД
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDbRepository<T> where T : BaseDocumentEntity
    {
        /// <summary>
        /// Метод добавления данных в таблицу
        /// </summary>
        /// <param name="entity">Добавляемая сущность в таблицы</param>
        /// <returns></returns>
        Task<Guid> Add(T entity);
    }
}
