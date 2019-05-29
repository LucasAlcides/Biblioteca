using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcidesMontadora.Models
{
    public class Cliente : Pessoa
    {
        public DateTime  DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string OrgaoExpedidor { get; set; }
        public string Rg { get; set; }
        public Cidade Cidade { get; set; }

        public enum Sexo
        {
            Masculino=1,
            Feminino=2
        }
        
    }
}
