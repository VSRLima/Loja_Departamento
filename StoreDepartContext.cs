using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using loja_depr.Models.Suggestion;
using loja_depr.Models.Colaborator;
using loja_depr.Models;
using loja_depr.Models.Map;
using loja_depr.Repositories;

namespace loja_depr.DAL
{
    public class StoreDepartContext : DbContext
    {
        public StoreDepartContext()
        {
            if (this.Database.IsSqlServer())
            {
                this.Database.SetCommandTimeout(500000);
            }
        }

        public StoreDepartContext(DbContextOptions<StoreDepartContext> options) : base(options)
        {
            if(this.Database.IsSqlServer())
            {
                this.Database.SetCommandTimeout(500000);
            }
        }

        public DbSet<Suggestions> Suggestions { get; set; }
        public DbSet<Colaborators> Colaborators { get; set; }
        public DbSet<Departaments> Departaments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SuggestionsMap());
            modelBuilder.ApplyConfiguration(new ColaboratorsMap());
            modelBuilder.ApplyConfiguration(new DepartamentsMap());
            base.OnModelCreating(modelBuilder);
        }

        public ISuggestionsRepository GetSuggestionsRepository()
        {
            return new SuggestionsRepository(this, Suggestions);
        }

        public IColaboratorsRepository GetColaboratorsRepository()
        {
            return new ColaboratorsRepository(this, Colaborators);
        }

        public IDepartamentsRepository GetDepartamentsRepository()
        {
            return new DepartamentsRepository(this, Departaments);
        }
    }
}