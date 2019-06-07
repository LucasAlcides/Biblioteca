using AlcidesLaboratorio.Contexto;
using AlcidesLaboratorio.Models;
using Microsoft.EntityFrameworkCore;
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
        public void Insert(T t)
        {
            db.Set<T>().Add(t);
        }
        public void Update(T t)
        {
            db.Entry(t).State = EntityState.Modified;
        }
        public void Delete(T t)
        {
            db.Set<T>().Remove(t);
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
            db.SaveChanges();
            db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
