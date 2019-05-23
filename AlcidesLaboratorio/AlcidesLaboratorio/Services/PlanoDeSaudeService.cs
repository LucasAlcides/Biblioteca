using AlcidesLaboratorio.Models;
using AlcidesLaboratorio.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcidesLaboratorio.Services
{
    public class PlanoDeSaudeService
    {
        private readonly PlanoDeSaudeRepositories planoDeSaudeRepositories;
        public PlanoDeSaudeService(PlanoDeSaudeRepositories planoDeSaudeRepositories)
        {
            this.planoDeSaudeRepositories = planoDeSaudeRepositories;
        }

        public void Add(PlanoDeSaude plano)
        {
            planoDeSaudeRepositories.Add(plano);
        }
        public IList<PlanoDeSaude> FindAll()
        {
            return planoDeSaudeRepositories.FindAll();
        }
        public void Delete(PlanoDeSaude plano)
        {
            planoDeSaudeRepositories.Delete(plano);
        
        }
        public IList<PlanoDeSaude> GetByDescricao(string descricao)
        {
            return planoDeSaudeRepositories.GetByDescricao(descricao);
        }
        public PlanoDeSaude GetById(int id)
        {
            return planoDeSaudeRepositories.GetById(id);
        }
    }
}
