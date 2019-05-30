using AlcidesLaboratorio.Models;
using AlcidesLaboratorio.Repositories;
using System.Collections.Generic;

namespace AlcidesLaboratorio.Services
{
    public class PacienteServices
    {
        private readonly PacienteRepository pacienteRepository;

        public PacienteServices(PacienteRepository pacienteRepository)
        {
            this.pacienteRepository = pacienteRepository;
        }
        public void Add(Paciente paciente)
        {
            pacienteRepository.Add(paciente);
        }
        public void Delete(Paciente paciente)
        {
            pacienteRepository.Delete(paciente);
        }
        public Paciente FindById(int id)
        {
            return pacienteRepository.GetById(id);
        }
        public IList<Paciente> FindByName(string nome)
        {
            return pacienteRepository.GetByNome(nome);
        }
        public IList<Paciente> FindAll()
        {
            return pacienteRepository.GetAll();
        }
    }
}
