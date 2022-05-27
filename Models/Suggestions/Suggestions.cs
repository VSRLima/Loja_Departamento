using System;
using System.Collections.Generic;
using loja_depr.Models.Colaborator;

namespace loja_depr.Models.Suggestion
{
    public partial class Suggestions : ISuggestions
    {
        public int Id { get;  set;  }
        public string Name { get;  set;  }
        public int DepartamentId { get;  set;  }
        public int ColaboratorsId { get;  set;  }
        public string Suggestion { get;  set;  }
        public string Reason { get;  set;  }

        
        public virtual Departaments Departament { get;  set;  }
        public virtual Colaborators Colaborators { get;  set;  }
    }
}