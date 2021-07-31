using JsonToPdf.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToPdf.Model.Repositories
{
    public interface IDbRepository<T> where T : BaseDocumentEntity
    {
        Task<Guid> Add(T entity);
    }
}
