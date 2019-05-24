using AlcidesMontadora.Models;
using AlcidesMontadora.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcidesMontadora.Services
{
    public class UsuarioServices
    {
        private readonly UsuarioRepository usuarioRepository;
        public UsuarioServices(UsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }
        
        public void Add(Usuario usuario)
        {
            usuarioRepository.Add(usuario);
        }
        public void Delete(Usuario usuario)
        {
            usuarioRepository.Delete(usuario);
        }
        public Usuario FindById(int id)
        {
            return usuarioRepository.GetById(id);
        }
        public IList<Usuario> GetAll()
        {
            return usuarioRepository.GetAll();
        }
        public IList<Usuario> GetByNome(string nome)
        {
            return usuarioRepository.GetByNome(nome);
        }
    }
}
