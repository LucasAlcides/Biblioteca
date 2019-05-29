using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlcidesMontadora.Models
{
    public class PecaDoVeiculo
    {
        public int PecaDoVeiculoId { get; set; }
        public decimal Desconto { get; set; }
        public int Quantidade { get; set; }
        public Peca Peca { get; set; }
        public Veiculo ObjVeiculo { get; set; }

        //private PecaDoVeiculo(Veiculo veiculo)
        //{
        //    ObjVeiculo = veiculo;
        //}

    }
}
