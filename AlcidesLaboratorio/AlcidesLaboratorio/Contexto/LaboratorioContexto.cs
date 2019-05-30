using AlcidesLaboratorio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcidesLaboratorio.Contexto
{
    public class LaboratorioContexto : DbContext
    {
        public LaboratorioContexto(DbContextOptions<LaboratorioContexto> DbContextoptions) : base(DbContextoptions)
        {
        }
        public DbSet<PlanoDeSaude> Planos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
    }
}
