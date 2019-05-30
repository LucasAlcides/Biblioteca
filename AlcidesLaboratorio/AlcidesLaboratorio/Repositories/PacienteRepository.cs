using AlcidesLaboratorio.Contexto;
using AlcidesLaboratorio.Models;
using System.Collections.Generic;
using System.Linq;

namespace AlcidesLaboratorio.Repositories
{
    public class PacienteRepository
    {
        public readonly LaboratorioContexto db;
        public PacienteRepository(LaboratorioContexto laboratorioContexto)
        {
            this.db = laboratorioContexto;
        }
        public void Add(Paciente paciente)
        {
            db.Pacientes.Add(paciente);
            db.SaveChanges();
        }
        public void Delete(Paciente paciente)
        {
            db.Pacientes.Remove(paciente);
            db.SaveChanges();
        }
        public IList<Paciente> GetByNome(string nome)
        {
            return db.Pacientes.Where(p => p.Nome.Contains(nome)).ToList();
        }
        public IList<Paciente> GetAll()
        {
             return  db.Pacientes.ToList();
        }
        public Paciente GetById(int id)
        {
            return db.Pacientes.Find(id);
        }
    }
}
