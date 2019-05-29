using AlcidesMontadora.Contexto;
using AlcidesMontadora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcidesMontadora.Repository
{
    public class PecaDoVeiculoRepository
    {
        private readonly MontadoraContexto Db;
        public PecaDoVeiculoRepository(MontadoraContexto montadoraContexto)
        {
            this.Db = montadoraContexto;
        }

        public void Add(PecaDoVeiculo pecaDoVeiculo)
        {
            Db.PecaDoVeiculo.Add(pecaDoVeiculo);
            Db.SaveChanges();
        }
        public IList<PecaDoVeiculo> GetAll()
        {
            return Db.PecaDoVeiculo.ToList();
        }
        public void Delete(PecaDoVeiculo pecaDoVeiculo)
        {
            Db.PecaDoVeiculo.Remove(pecaDoVeiculo);
            Db.SaveChanges();
        }
        public PecaDoVeiculo GetById(int id)
        {
            return Db.PecaDoVeiculo.Find(id);
        }
    }
}
