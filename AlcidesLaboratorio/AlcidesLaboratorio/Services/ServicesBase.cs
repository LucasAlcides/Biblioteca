using AlcidesLaboratorio.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcidesLaboratorio.Services
{
    public class ServicesBase<T> where T : class
    {
        private readonly RepositorioBase<T> repositorioBase;
        public ServicesBase(RepositorioBase<T> repoBase)
        {
            this.repositorioBase = repoBase;
        }

        public void Insert(T t)
        {
            repositorioBase.Insert(t);
        }
        public void Delete(T t)
        {
            repositorioBase.Delete(t);
        }
        public void Update(T t)
        {
            repositorioBase.Update(t);
        }

    }
}
