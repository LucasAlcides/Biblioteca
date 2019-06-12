using AlcidesMontadora.Contexto;
using AlcidesMontadora.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcidesMontadora.Repository
{
    public class UsuarioRepository
    {
        private readonly MontadoraContexto Db;
        public UsuarioRepository(MontadoraContexto montadoraContexto)
        {
            this.Db = montadoraContexto;
        }

        public void Add(Usuario usuario)
        {
            Db.Usuarios.Add(usuario);
            Db.SaveChanges();
        }
        public IList<Usuario> GetAll()
        {
            return Db.Usuarios.ToList();
        }
        public void Delete(Usuario usuario)
        {
            Db.Usuarios.Remove(usuario);
            Db.SaveChanges();
        }
        public void Update(Usuario usuario)
        {
            Db.Entry(usuario).State = EntityState.Modified;
        }
        public Usuario GetById(int id)
        {
            return Db.Usuarios.Find(id);
        }
        public IList<Usuario> GetByNome(string nome)
        {
            return Db.Usuarios.Where(n => n.Nome.Contains(nome)).ToList();
        }

    }
}
