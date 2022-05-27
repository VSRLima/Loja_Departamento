using loja_depr.Models;
using System;
using System.Collections.Generic;

namespace loja_depr.Repositories
{
    public interface IDepartamentsRepository : IEntityFrameworkRepository<IDepartaments>
    {
        IEnumerable<IDepartaments> GetAll();
    }

}