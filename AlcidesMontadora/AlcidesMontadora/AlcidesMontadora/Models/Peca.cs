using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcidesMontadora.Models
{
    public class Peca
    {
        public DateTime DataFabricacao { get; set; }
        public string Descricao { get; set; }
        public string NumeroSerie { get; set; }
        public int PecaId { get; set; }
        public decimal Valor { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}
