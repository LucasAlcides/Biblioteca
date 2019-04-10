using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Biblioteca.Repositorio;

namespace Biblioteca.Models
{
    public class Emprestimo
    {
        public Funcionario Funcionario { get; set; }
        public Aluno Aluno { get; set; }
        public IList<ItensEmprestimo> ItensEmprestimos { get; set; }
        [Required(ErrorMessage = "A data do Emprestimo e obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Data do Emprestimo")]
        public DateTime DtEmprestimo { get; set; }
        public int Id { get; set; }
        [Required(ErrorMessage = "O valor total e obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Valor Total")]
        public double ValorTotal { get; set; }

        public void Insert()
        {
        }
        public void Update()
        {
        }
        public void Delete()
        {
        }
        public Emprestimo SearchForId(int id)
        {
            Emprestimo emprestimo = new Emprestimo();
            foreach (Emprestimo item in Banco.emprestimos)
            {
                if (item.Id == id)
                {
                    emprestimo = item;
                }
            }
            return emprestimo;
        }
        public IList<Emprestimo> SearchForAll()
        {
            return Banco.emprestimos;
        }
        public Emprestimo SearchForDate(Emprestimo emprestimo)
        {
            Emprestimo emprestimoTRUE = new Emprestimo();
            foreach (Emprestimo item in Banco.emprestimos)
            {
                if (item.DtEmprestimo == emprestimo.DtEmprestimo)
                {
                    emprestimoTRUE = item;
                }
            }
            return emprestimoTRUE;
        }
    }
}
