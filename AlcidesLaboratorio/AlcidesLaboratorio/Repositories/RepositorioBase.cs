using AlcidesLaboratorio.Contexto;
using AlcidesLaboratorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcidesLaboratorio.Repositories
{

    public class RepositorioBase<T> where T:class
    {
        public readonly LaboratorioContexto db;
        public RepositorioBase(LaboratorioContexto laboratorioContexto)
        {
            this.db = laboratorioContexto;
        }
        public void Add(T t)
        {
            db.Set<T>().Add(t);
            db.SaveChanges();
        }
        public void Delete(T t)
        {
            db.Set<T>().Remove(t);
            db.SaveChanges();
        }
        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }
        public IList<T> GetAll()
        {
            return db.Set<T>().ToList();
        }
        public void Dispose()
        {
            db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
