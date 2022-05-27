using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using loja_depr.Models;
using loja_depr.DAL;

namespace loja_depr.Repositories
{
    public class DepartamentsRepository : EntityFrameworkRepository<Departaments>, IDepartamentsRepository
    {
        public DepartamentsRepository(StoreDepartContext context) : base(context)
        {
        }

        public DepartamentsRepository(StoreDepartContext context, DbSet<Departaments> entities) : base(context, entities)
        {
        }

        public void Add(IDepartaments entity) => base.Add((Departaments)entity);
        
        public IEnumerable<IDepartaments> Find(Expression<Func<Departaments, bool>> predicate) => base.Find(predicate);

        //TODO: Solve this implementation (ERROR: Type are differ)
        public IEnumerable<IDepartaments> Find(Expression<Func<IDepartaments, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Remove(IDepartaments entity) => base.Remove((Departaments)entity);

        public void Update(IDepartaments entity) => base.Update((Departaments)entity);

        IEnumerable<IDepartaments> IDepartamentsRepository.GetAll()
        {
            return base.GetAll();
        }

        IEnumerable<IDepartaments> IEntityFrameworkRepository<IDepartaments>.GetAll()
        {
            return base.GetAll();
        }

        IDepartaments IEntityFrameworkRepository<IDepartaments>.GetById(int id) => base.GetById(id);
    }
}