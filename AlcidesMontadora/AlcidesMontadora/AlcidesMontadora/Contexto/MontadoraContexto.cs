using AlcidesMontadora.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcidesMontadora.Contexto
{
    public class MontadoraContexto : DbContext
    {
        public MontadoraContexto(DbContextOptions<MontadoraContexto> dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Peca> Peca { get; set; }
        public DbSet<PecaDoVeiculo> PecaDoVeiculo{ get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Montador> Montador { get; set; }
        public DbSet<Veiculo> Veiculo { get; set; }


    }
}
