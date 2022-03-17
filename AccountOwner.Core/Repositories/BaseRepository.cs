using AccountOwner.Domain.Contracts;
using AccountOwner.Domain.EF.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AccountOwner.Core.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly AccountOwnerContext db = null;

        public BaseRepository(AccountOwnerContext db)
        {
            this.db = db;
        }

        public void Create(TEntity entity)
        {
            db.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            this.db.Set<TEntity>().Remove(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this.db.Set<TEntity>().ToList();
        }

        public IQueryable<TEntity> GetByCondition(Expression<Func<TEntity, bool>> expression)
        {
            return this.db.Set<TEntity>().Where(expression).AsNoTracking();
        }

        public void Update(TEntity entity)
        {
            this.db.Entry(entity);
            this.db.Attach(entity).State = EntityState.Modified;
        }
    }
}
