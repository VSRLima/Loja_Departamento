using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using loja_depr.Models.Suggestion;
using loja_depr.DAL;

namespace loja_depr.Repositories
{
    public class SuggestionsRepository : EntityFrameworkRepository<Suggestions>, ISuggestionsRepository
    {
        public SuggestionsRepository(StoreDepartContext context) : base(context)
        {
        }

        public SuggestionsRepository(StoreDepartContext context, DbSet<Suggestions> entities) : base(context, entities)
        {
        }

        public void Add(Suggestions entity)
        {
            base.Add(entity);
        }

        public IEnumerable<Suggestions> Find(Expression<Func<Suggestions, bool>> predicate)
        {
            return base.Find(predicate);
        }

        public void Remove(Suggestions entity)
        {
            base.Remove(entity);
        }

        public void Update(Suggestions entity)
        {
            base.Update(entity);
        }

        IEnumerable<Suggestions> ISuggestionsRepository.GetAll()
        {
            return base.GetAll();
        }

        IEnumerable<Suggestions> IEntityFrameworkRepository<Suggestions>.GetAll()
        {
            return base.GetAll();
        }

        Suggestions IEntityFrameworkRepository<Suggestions>.GetById(int id)
        {
            return base.GetById(id);
        }
    }
}