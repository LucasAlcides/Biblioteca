using AlcidesMontadora.Models;
using AlcidesMontadora.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcidesMontadora.Services
{
    public class PecaServices
    {
        private readonly PecaRepository pecaRepository;

        public PecaServices(PecaRepository pecaRepository)
        {
            this.pecaRepository = pecaRepository;
        }

        public void Add(Peca peca)
        {
            pecaRepository.Add(peca);
        }
        public void Delete(Peca peca)
        {
            pecaRepository.Delete(peca);
        }
        public void Update(Peca peca)
        {
            pecaRepository.Update(peca);
        }
        public IList<Peca> FindAll()
        {
            return pecaRepository.GetAll();
        }
        public Peca FindById(int id)
        {
            return pecaRepository.GetById(id);
        }
        public IList<Peca> FindByDescricao(string descricao)
        {
            return pecaRepository.GetByDescricao(descricao);
        }
    }
}
