using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TemplateProjeto.Domain.Abstractions.Repositories;
using TemplateProjeto.Domain.Models;
using TemplateProjeto.Infrastructure.Repository.Context;

namespace TemplateProjeto.Infrastructure.Repository.Implementations
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : Entity
    {
        protected DbSet<TEntity> DbSet;
        protected DbContextBase DbContext;

        public RepositoryBase(DbContextBase dbContext)
        {
            DbContext = dbContext;
            DbSet = DbContext.Set<TEntity>();
        }

        public virtual async Task<TEntity> GetByIdAsync(int entityId)
        {
            return await DbSet.FindAsync(entityId).ConfigureAwait(false);
        }

        public virtual async Task AddAsync(TEntity entity)
        {
            await DbSet.AddAsync(entity).ConfigureAwait(false);
        }

        public virtual Task RemoveAsync(TEntity entity)
        {
            DbSet.Remove(entity);
            return Task.CompletedTask;
        }

        public virtual async Task UpdateAsync(int entityId, TEntity newEntity)
        {
            var trackedEntity = await DbSet.SingleOrDefaultAsync(register => register.Id == entityId);
            DbContext.Entry(trackedEntity).CurrentValues.SetValues((TEntity)newEntity.WithId(entityId));
        }

        public virtual async Task SaveChangesAsync()
        {
            await DbContext.SaveChangesAsync();
        }

    }
}
