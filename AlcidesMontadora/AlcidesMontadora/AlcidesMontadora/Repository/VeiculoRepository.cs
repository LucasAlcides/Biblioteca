using AlcidesMontadora.Contexto;
using AlcidesMontadora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcidesMontadora.Repository
{
    public class VeiculoRepository
    {
        private readonly MontadoraContexto Db;

        public VeiculoRepository(MontadoraContexto montadoraContexto)
        {
            this.Db = montadoraContexto;
        }
        public void Add(Veiculo veiculo)
        {
            Db.Veiculo.Add(veiculo);
            Db.SaveChanges();
        }
        public IList<Veiculo> GetAll()
        {
            return Db.Veiculo.ToList();
        }
        public void Delete(Veiculo veiculo)
        {
            Db.Veiculo.Remove(veiculo);
            Db.SaveChanges();
        }
        public Veiculo GetById(int id)
        {
            return Db.Veiculo.Find(id);
        }
        public IList<Veiculo> GetByModelo(string modelo)
        {
            return Db.Veiculo.Where(n => n.Modelo.Contains(modelo)).ToList();
        }
    }
}
