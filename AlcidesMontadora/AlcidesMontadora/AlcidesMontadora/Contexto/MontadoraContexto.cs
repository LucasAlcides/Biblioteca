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
    }
}
