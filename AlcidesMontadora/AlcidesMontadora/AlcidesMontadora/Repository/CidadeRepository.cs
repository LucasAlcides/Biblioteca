using AlcidesMontadora.Contexto;
using AlcidesMontadora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcidesMontadora.Repository
{
    public class CidadeRepository
    {
        private readonly MontadoraContexto Db;

        public CidadeRepository(MontadoraContexto montadoraContexto)
        {
            this.Db = montadoraContexto;        
        }
        public void Add(Cidade cidade)
        {
            Db.Cidade.Add(cidade);
            Db.SaveChanges();
        }
        public IList<Cidade> GetAll()
        {
           return Db.Cidade.ToList();
        }
        public void Delete(Cidade cidade)
        {
            Db.Cidade.Remove(cidade);
            Db.SaveChanges();
        }
        public Cidade GetById(int id)
        {
            return Db.Cidade.Find(id);
        }
        public IList<Cidade> GetByNome(string nome)
        {
            return Db.Cidade.Where(n => n.Nome.Contains(nome)).ToList();
        }
    }
}
