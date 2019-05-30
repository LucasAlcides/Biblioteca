using System;

namespace AlcidesLaboratorio.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public PlanoDeSaude PlanoDeSaude { get; set; }
    }
}
