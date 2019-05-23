using AlcidesLaboratorio.Contexto;
using AlcidesLaboratorio.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcidesLaboratorio.Repositories
{
    public class PlanoDeSaudeRepositories
    {
        private readonly LaboratorioContexto Db;
        public PlanoDeSaudeRepositories(LaboratorioContexto labContext)
        {
            this.Db = labContext;
        }
        public void Add(PlanoDeSaude plano)
        {
            Db.Planos.Add(plano);
            Db.SaveChanges();
        }
        public IList<PlanoDeSaude> FindAll()
        {
            return Db.Planos.ToList();
        }
        public void Delete(PlanoDeSaude plano)
        {
            Db.Planos.Remove(plano);
            Db.SaveChanges();
        }
        public IList<PlanoDeSaude> GetByDescricao(string descricao)
        {
          return Db.Planos.Where(p => p.Descricao.Contains(descricao)).ToList();
        }
        public PlanoDeSaude GetById(int id)
        {
            return Db.Planos.Find(id);
        }
       

    }
}
