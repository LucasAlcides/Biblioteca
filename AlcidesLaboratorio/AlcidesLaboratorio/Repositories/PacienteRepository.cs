using AlcidesLaboratorio.Contexto;
using AlcidesLaboratorio.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AlcidesLaboratorio.Repositories
{
    public class PacienteRepository : RepositorioBase<Paciente>
    {
        private readonly LaboratorioContexto db;
        public PacienteRepository(LaboratorioContexto laboratorioContexto) : base(laboratorioContexto)
        {
            this.db = laboratorioContexto;
        }
        
        public IList<Paciente> GetByNome(string nome)
        {
            return db.Pacientes.Where(p => p.Nome.Contains(nome)).ToList();
        }
        public IList<Paciente> GetAll()
        {
            return db.Pacientes.Include(p => p.PlanoDeSaude).ToList();
        }

    }
}
