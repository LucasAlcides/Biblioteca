using AlcidesMontadora.Models;
using AlcidesMontadora.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcidesMontadora.Services
{
    public class VeiculoServices
    {
        private readonly VeiculoRepository veiculoRepository;

        public VeiculoServices(VeiculoRepository veiculoRepository)
        {
            this.veiculoRepository = veiculoRepository;
        }

        public void Add(Veiculo veiculo)
        {
            veiculoRepository.Add(veiculo);
        }
        public void Update(Veiculo veiculo)
        {
            veiculoRepository.Update(veiculo);
        }
        public void Delete(Veiculo veiculo)
        {
            veiculoRepository.Delete(veiculo);
        }
        public IList<Veiculo> FindAll()
        {
            return veiculoRepository.GetAll();
        }
        public Veiculo FindById(int id)
        {
            return veiculoRepository.GetById(id);
        }
        public IList<Veiculo> FindByModelo(string modelo)
        {
            return veiculoRepository.GetByModelo(modelo);
        }
    }
}
