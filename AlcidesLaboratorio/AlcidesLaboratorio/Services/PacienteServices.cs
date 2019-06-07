using AlcidesLaboratorio.Models;
using AlcidesLaboratorio.Repositories;
using System.Collections.Generic;

namespace AlcidesLaboratorio.Services
{
    public class PacienteServices : ServicesBase<Paciente>
    {
        private readonly PacienteRepository pacienteRepository;

        public PacienteServices(PacienteRepository pacienteRepository) : base(pacienteRepository)
        {
            this.pacienteRepository = pacienteRepository;
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
