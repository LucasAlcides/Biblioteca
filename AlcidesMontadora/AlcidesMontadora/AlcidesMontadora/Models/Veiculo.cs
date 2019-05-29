using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcidesMontadora.Models
{
    public class Veiculo
    {
        public string Categoria { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int VeiculoId { get; set; }
        public Cliente Cliente { get; set; }
        public Montador Montador { get; set; }
        public IList<PecaDoVeiculo> ListaPecaDoVeiculo { get; set; }
    }
}
