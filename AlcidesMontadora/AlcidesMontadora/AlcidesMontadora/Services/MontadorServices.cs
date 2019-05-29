using AlcidesMontadora.Models;
using AlcidesMontadora.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcidesMontadora.Services
{
    public class MontadorServices
    {
        private readonly MontadorRepository montadorRepository;

        public MontadorServices(MontadorRepository montadorRepository)
        {
            this.montadorRepository = montadorRepository;
        }

        public void Add(Montador montador)
        {
            montadorRepository.Add(montador);
        }
        public void Delete(Montador montador)
        {
            montadorRepository.Delete(montador);
        }
        public IList<Montador> FindAll()
        {
            return montadorRepository.GetAll();
        }
        public Montador FindById(int id)
        {
            return montadorRepository.GetById(id);
        }
        public IList<Montador> FindByName(string name)
        {
            return montadorRepository.GetByNome(name);
        }
    }
}
