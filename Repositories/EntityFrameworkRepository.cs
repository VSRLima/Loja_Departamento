using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using loja_depr.DAL;

namespace loja_depr.Repositories
{
    public class EntityFrameworkRepository<T> : IEntityFrameworkRepository<T> where T : class, new()
    {
        protected readonly StoreDepartContext _context;
        protected readonly DbSet<T> entities;

        public EntityFrameworkRepository(StoreDepartContext context)
        {
            _context = context;
        }

        public EntityFrameworkRepository(StoreDepartContext context, DbSet<T> entities)
        {
            _context = context;
            this.entities = entities;
        }

        public void Add(T entity)
        {
            entities.Add(entity);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            if (entities == null)
                return Enumerable.Empty<T>();

            return entities.Where(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            if (entities == null)
                return Enumerable.Empty<T>();

            return entities.ToList();
        }

        public T GetById(int id)
        {
            return _context.Find<T>(id);
        }

        public void Remove(T entity)
        {
            _context.Remove(entity);
        }

        public void RemoveById(int id)
        {
            var entity = _context.Find<T>(id);
            _context.Remove(entity);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }
    }
}