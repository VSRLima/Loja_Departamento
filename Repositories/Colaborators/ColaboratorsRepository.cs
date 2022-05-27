using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using loja_depr.Models;
using loja_depr.Models.Colaborator;
using loja_depr.DAL;

namespace loja_depr.Repositories
{
    public class ColaboratorsRepository : EntityFrameworkRepository<Colaborators>, IColaboratorsRepository
    {
        public ColaboratorsRepository(StoreDepartContext context) : base(context)
        {
        }

        public ColaboratorsRepository(StoreDepartContext context, DbSet<Colaborators> entities) : base(context, entities)
        {
        }

        public void Add(Colaborators entity)
        {
            base.Add(entity);
        }

        public IEnumerable<Colaborators> Find(Expression<Func<Colaborators, bool>> predicate)
        {
            return base.Find(predicate);
        }

        public void Remove(Colaborators entity)
        {
            base.Remove(entity);
        }

        public void Update(Colaborators entity)
        {
            base.Update(entity);
        }

        IEnumerable<Colaborators> IColaboratorsRepository.GetAll()
        {
            return base.GetAll();
        }

        IEnumerable<Colaborators> IEntityFrameworkRepository<Colaborators>.GetAll()
        {
            return base.GetAll();
        }

        Colaborators IEntityFrameworkRepository<Colaborators>.GetById(int id)
        {
            return base.GetById(id);
        }
    }
}