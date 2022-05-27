using System;
using System.Collections.Generic;
using loja_depr.Models.Suggestion;

namespace loja_depr.Models.Colaborator
{
    public partial class Colaborators : IColaborators
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartamentId { get; set; }

        public virtual Departaments Departament { get; set; }
        public virtual ICollection<Suggestions> Suggestions { get; set; }
    }
}