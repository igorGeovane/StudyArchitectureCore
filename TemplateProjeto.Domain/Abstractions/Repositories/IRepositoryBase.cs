using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TemplateProjeto.Domain.Abstractions.Repositories
{
    public interface IRepositoryBase<TEntity>
    {
        Task<TEntity> GetByIdAsync(int entityId);

        Task AddAsync(TEntity entity);

        Task UpdateAsync(int entityId, TEntity newEntity);

        Task RemoveAsync(TEntity entity);

        Task SaveChangesAsync();
    }
}
