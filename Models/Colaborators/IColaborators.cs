using System;
using System.Collections.Generic;
using loja_depr.Models;

namespace loja_depr.Models.Colaborator
{
    public interface IColaborators
    {
        int Id { get; set; }
        string Name { get; set; }
        int DepartamentId { get; set; }
        
        Departaments Departament { get; set; }
    }
}