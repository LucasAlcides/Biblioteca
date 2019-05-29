using AlcidesMontadora.Models;
using AlcidesMontadora.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcidesMontadora.Services
{
    public class FonecedorServices
    {
        private readonly FornecedorRepository fornecedorRepository;

        public FonecedorServices(FornecedorRepository fornecedorRepository)
        {
            this.fornecedorRepository = fornecedorRepository;
        }

        public void Add(Fornecedor fornecedor)
        {
            fornecedorRepository.Add(fornecedor);
        }
        public void Delete(Fornecedor fornecedor)
        {
            fornecedorRepository.Delete(fornecedor);
            fornecedorRepository.Delete(fornecedor);
        }
        public IList<Fornecedor> FindAll()
        {
            return fornecedorRepository.GetAll();
        }
        public Fornecedor FindById(int id)
        {
            return fornecedorRepository.GetById(id);
        }
        public IList<Fornecedor> FindByName(string name)
        {
            return fornecedorRepository.GetByNome(name);
        }
    }
}
