using loja_depr.Models.Colaborator;
using System;
using System.Collections.Generic;

namespace loja_depr.Repositories
{
    public interface IColaboratorsRepository : IEntityFrameworkRepository<Colaborators>
    {
        IEnumerable<Colaborators> GetAll();
    }
}
