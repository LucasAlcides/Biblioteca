using AlcidesMontadora.Models;
using AlcidesMontadora.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcidesMontadora.Services
{
    public class ClienteServices
    {
        private readonly ClienteRepository clienteRepository;
        public ClienteServices(ClienteRepository clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }

        public void Add(Cliente cliente)
        {
            clienteRepository.Add(cliente);
        }
        public void Delete(Cliente cliente)
        {
            clienteRepository.Delete(cliente);
        }
        public Cliente FindById(int id)
        {
            return clienteRepository.GetById(id);
        }
        public IList<Cliente> GetAll()
        {
            return clienteRepository.GetAll();
        }
        public IList<Cliente> GetByNome(string nome)
        {
            return clienteRepository.GetByNome(nome);
        }
    }
}
