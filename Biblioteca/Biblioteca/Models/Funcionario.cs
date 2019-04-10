using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Biblioteca.Repositorio;

namespace Biblioteca.Models
{
    public class Funcionario : Pessoa
    {
        [Required(ErrorMessage = "Cargo e obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Informe o Cargo")]
        public string Cargo { get; set; }
        [Required(ErrorMessage = "A data da admissão e obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Informe a data da admissão")]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public DateTime DataAdmissao { get; set; }
        [Required(ErrorMessage = "Matricula e obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Informe a Matricula")]
        public string Matricula { get; set; }
        [Required(ErrorMessage = "PIS e obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Informe o PIS")]
        public string Pis { get; set; }
        [Required(ErrorMessage = "Salario e obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Informe um Salario")]
        [DataType(DataType.Currency)]
        public double Salario { get; set; }


        public void Insert()
        {
            Random r = new Random();
            this.Id = r.Next(1, 9999);
            Banco.funcionarios.Add(this);
        }
        public void Update()
        {
            Funcionario funcionario = Banco.funcionarios.First(x => x.Id == this.Id);
            funcionario.Cargo = this.Cargo;
            funcionario.Cpf = this.Cpf;
            funcionario.DataAdmissao = this.DataAdmissao;
            funcionario.Matricula = this.Matricula;
            funcionario.Nome = this.Nome;
            funcionario.Pis = this.Pis;
            funcionario.Salario = this.Salario;
        }
        public void Delete()
        {
            Funcionario funcionario = Banco.funcionarios.First(Funcionario => Funcionario.Id == this.Id);
            Banco.funcionarios.Remove(funcionario);
        }
        public IList<Funcionario> SearchForAll()
        {
            return Banco.funcionarios;
        }
        public Funcionario  SearchForId(int id)
        {
            return Banco.funcionarios.FirstOrDefault(x => x.Id == id);
        }
    }
}
