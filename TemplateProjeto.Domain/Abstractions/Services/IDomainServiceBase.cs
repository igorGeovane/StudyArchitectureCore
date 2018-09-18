using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TemplateProjeto.Domain.Models;

namespace TemplateProjeto.Domain.Abstractions.Services
{
    public interface IDomainServiceBase<TEntity> where TEntity : Entity
    {
        Task<TEntity> GetByIdAsync(int entityId);

        Task<TEntity> AddAsync(TEntity entity);

        Task<TEntity> UpdateAsync(int entityId, TEntity entity);

        Task DeleteAsync(TEntity entity);
    }
}
