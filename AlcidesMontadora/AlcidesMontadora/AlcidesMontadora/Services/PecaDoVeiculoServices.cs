using AlcidesMontadora.Models;
using AlcidesMontadora.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcidesMontadora.Services
{
    public class PecaDoVeiculoServices
    {
        private readonly PecaDoVeiculoRepository pecaDoVeiculoRepository;

        public PecaDoVeiculoServices(PecaDoVeiculoRepository pecaDoVeiculoRepository)
        {
            this.pecaDoVeiculoRepository = pecaDoVeiculoRepository;
        }

        public void Add(PecaDoVeiculo pecaDoVeiculo)
        {
            pecaDoVeiculoRepository.Add(pecaDoVeiculo);
        }
        public void Delete(PecaDoVeiculo pecaDoVeiculo)
        {
            pecaDoVeiculoRepository.Delete(pecaDoVeiculo);
        }
        public IList<PecaDoVeiculo> FindAll()
        {
            return pecaDoVeiculoRepository.GetAll();
        }
        public PecaDoVeiculo FindById(int id)
        {
            return pecaDoVeiculoRepository.GetById(id);
        }
 
    }
}
