using AlcidesMontadora.Contexto;
using AlcidesMontadora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcidesMontadora.Repository
{
    public class ClienteRepository
    {
        private readonly MontadoraContexto Db;

        public ClienteRepository(MontadoraContexto montadoraContexto)
        {
            this.Db = montadoraContexto;
        }
        public void Add(Cliente cliente)
        {
            Db.Cliente.Add(cliente);
            Db.SaveChanges();
        }
        public IList<Cliente> GetAll()
        {
            return Db.Cliente.ToList();
        }
        public void Delete(Cliente cliente)
        {
            Db.Cliente.Remove(cliente);
            Db.SaveChanges();
        }
        public Cliente GetById(int id)
        {
            return Db.Cliente.Find(id);
        }
        public IList<Cliente> GetByNome(string nome)
        {
            return Db.Cliente.Where(n => n.Nome.Contains(nome)).ToList();
        }
    }
}
