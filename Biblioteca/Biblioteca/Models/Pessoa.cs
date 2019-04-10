using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = "CPF e obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Informe seu CPF", Description = "Ex: 000.000.000-00")]
        public string Cpf { get; set; }
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome Completo e obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome Completo", Description = "Nome e Sobrenome")]
        public string Nome { get; set; }
    }
}
