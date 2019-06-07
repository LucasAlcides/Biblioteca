using AlcidesLaboratorio.Contexto;
using AlcidesLaboratorio.Models;
using System.Collections.Generic;
using System.Linq;

namespace AlcidesLaboratorio.Repositories
{
    public class PlanoDeSaudeRepositories : RepositorioBase<PlanoDeSaude>
    {
        private readonly LaboratorioContexto Db;
        public PlanoDeSaudeRepositories(LaboratorioContexto labContext) : base(labContext)
        {
            this.Db = labContext;
        }
       
        public IList<PlanoDeSaude> GetByDescricao(string descricao)
        {
          return Db.Planos.Where(p => p.Descricao.Contains(descricao)).ToList();
        }
        

    }
}
