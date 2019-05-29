using AlcidesMontadora.Contexto;
using AlcidesMontadora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcidesMontadora.Repository
{
    public class MontadorRepository
    {
        private readonly MontadoraContexto Db;

        public MontadorRepository(MontadoraContexto montadoraContexto)
        {
            this.Db = montadoraContexto;
        }
        public void Add(Montador montador)
        {
            Db.Montador.Add(montador);
            Db.SaveChanges();
        }
        public IList<Montador> GetAll()
        {
            return Db.Montador.ToList();
        }
        public void Delete(Montador montador)
        {
            Db.Montador.Remove(montador);
            Db.SaveChanges();
        }
        public Montador GetById(int id)
        {
            return Db.Montador.Find(id);
        }
        public IList<Montador> GetByNome(string nome)
        {
            return Db.Montador.Where(n => n.Nome.Contains(nome)).ToList();
        }
    }
}
