using JsonToPdf.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToPdf.Model.Repositories
{
    /// <summary>
    /// Класс для взаимодействия с БД
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DbRepository<T> : IDbRepository<T> where T : BaseDocumentEntity
    {
        private readonly DataContext _context;

        public DbRepository(DataContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Метод для добавления параметров в Базу данных
        /// </summary>
        /// <param name="entity">Сущность добавляемого документа</param>
        /// <returns>Id добавленного документа</returns>
        public async Task<Guid> Add(T entity)
        {
            var result = await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return result.Entity.Id;
        }

    }
}
