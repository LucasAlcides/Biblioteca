using AlcidesLaboratorio.Models;
using AlcidesLaboratorio.Repositories;
using System.Collections.Generic;

namespace AlcidesLaboratorio.Services
{
    public class PlanoDeSaudeService : ServicesBase<PlanoDeSaude>
    {
        private readonly PlanoDeSaudeRepositories planoDeSaudeRepositories;
        public PlanoDeSaudeService(PlanoDeSaudeRepositories planoDeSaudeRepositories) : base(planoDeSaudeRepositories)
        {
            this.planoDeSaudeRepositories = planoDeSaudeRepositories;
        }

        public IList<PlanoDeSaude> FindByDescricao(string descricao)
        {
            return planoDeSaudeRepositories.GetByDescricao(descricao);
        }
        public PlanoDeSaude FindById(int id)
        {
            return planoDeSaudeRepositories.GetById(id);
        }
        public IList<PlanoDeSaude> FindAll()
        {
            return planoDeSaudeRepositories.GetAll();
        }
    }
}
