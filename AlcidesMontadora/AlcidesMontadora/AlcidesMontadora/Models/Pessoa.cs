using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcidesMontadora.Models
{
    public abstract class Pessoa
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }

    }
}
