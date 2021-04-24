using Bankruptcy.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bankruptcy.Application.Common.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> AddAsync(TEntity entity);
        Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
