using System;
using System.Collections.Generic;
using loja_depr.Models.Colaborator;
using loja_depr.Models.Suggestion;

namespace loja_depr.Models
{
    public partial class Departaments : IDepartaments
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Colaborators> Colaborators { get; set; }
        public virtual ICollection<Suggestions> Suggestions { get; set; }
    }
}