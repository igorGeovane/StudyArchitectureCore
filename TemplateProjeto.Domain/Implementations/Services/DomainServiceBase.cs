using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TemplateProjeto.Domain.Abstractions.Repositories;
using TemplateProjeto.Domain.Abstractions.Services;
using TemplateProjeto.Domain.Models;

namespace TemplateProjeto.Domain.Implementations.Services
{
    public class DomainServiceBase<TEntity> : IDomainServiceBase<TEntity> where TEntity : Entity
    {
        private readonly IRepositoryBase<TEntity> _entityRepository;
        protected DomainServiceBase(IRepositoryBase<TEntity> entityRepository)
        {
            _entityRepository = entityRepository;
        }

        public virtual async Task<TEntity> GetByIdAsync(int entityId)
        {
            return await _entityRepository.GetByIdAsync(entityId);
        }

        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            await _entityRepository.AddAsync(entity);
            await _entityRepository.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<TEntity> UpdateAsync(int entityId, TEntity entity)
        {
            await _entityRepository.UpdateAsync(entityId, entity);
            await _entityRepository.SaveChangesAsync();
            return entity;
        }
        public virtual async Task DeleteAsync(TEntity entity)
        {
            await _entityRepository.RemoveAsync(entity);
            await _entityRepository.SaveChangesAsync();
        }
    }
}
