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

        public void Add(T t)
        {
            repositorioBase.Add(t);
        }
        public void Delete(T t)
        {
            repositorioBase.Delete(t);
        }
        public IList<T> GetAll()
        {
            return repositorioBase.GetAll();
        }
        public T GetById(int id)
        {
            return repositorioBase.GetById(id);
        }
    }
}
