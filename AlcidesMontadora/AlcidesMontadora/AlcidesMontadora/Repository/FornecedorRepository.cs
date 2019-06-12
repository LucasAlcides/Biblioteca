using AlcidesMontadora.Contexto;
using AlcidesMontadora.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcidesMontadora.Repository
{
    public class FornecedorRepository
    {
        private readonly MontadoraContexto Db;
        public FornecedorRepository(MontadoraContexto montadoraContexto)
        {
            this.Db = montadoraContexto;
        }

        public void Add(Fornecedor fornecedor)
        {
            Db.Fornecedor.Add(fornecedor);
            Db.SaveChanges();
        }
        public IList<Fornecedor> GetAll()
        {
            return Db.Fornecedor.ToList();
        }
        public void Delete(Fornecedor fornecedor)
        {
            Db.Fornecedor.Remove(fornecedor);
            Db.SaveChanges();
        }
        public void Update(Fornecedor fornecedor)
        {
            Db.Entry(fornecedor).State = EntityState.Modified;
        }
        public Fornecedor GetById(int id)
        {
            return Db.Fornecedor.Find(id);
        }
        public IList<Fornecedor> GetByNome(string nome)
        {
            return Db.Fornecedor.Where(n => n.Nome.Contains(nome)).ToList();
        }
    }
}
