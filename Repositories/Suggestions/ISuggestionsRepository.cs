using loja_depr.Models.Suggestion;
using System;
using System.Collections.Generic;

namespace loja_depr.Repositories
{
    public interface ISuggestionsRepository : IEntityFrameworkRepository<Suggestions>
    {
        IEnumerable<Suggestions> GetAll();
    }
}