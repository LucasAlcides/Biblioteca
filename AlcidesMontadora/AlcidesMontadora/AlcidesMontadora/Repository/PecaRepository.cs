using AlcidesMontadora.Contexto;
using AlcidesMontadora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcidesMontadora.Repository
{
    public class PecaRepository
    {
        private readonly MontadoraContexto Db;

        public PecaRepository(MontadoraContexto montadoraContexto)
        {
            this.Db = montadoraContexto;
        }
        public void Add(Peca peca)
        {
            Db.Peca.Add(peca);
            Db.SaveChanges();
        }
        public IList<Peca> GetAll()
        {
            return Db.Peca.ToList();
        }
        public void Delete(Peca peca)
        {
            Db.Peca.Remove(peca);
            Db.SaveChanges();
        }
        public Peca GetById(int id)
        {
            return Db.Peca.Find(id);
        }
        public IList<Peca> GetByDescricao(string descricao)
        {
            return Db.Peca.Where(n => n.Descricao.Contains(descricao)).ToList();
        }
    }
}
