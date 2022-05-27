using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace loja_depr.Repositories
{
    public interface IEntityFrameworkRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        void RemoveById(int id);
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        int SaveChanges();
    }
}