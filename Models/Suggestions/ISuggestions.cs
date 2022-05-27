using System;
using System.Collections.Generic;
using loja_depr.Models;
using loja_depr.Models.Colaborator;

namespace loja_depr.Models.Suggestion
{
    public interface ISuggestions
    {
        int Id { get; set; }
        string Name { get; set; }
        int DepartamentId { get; set; }
        int ColaboratorsId { get; set; }
        string Suggestion { get; set; }
        string Reason { get; set; }
        Departaments Departament { get; set; }
        Colaborators Colaborators { get; set; }
    }
}