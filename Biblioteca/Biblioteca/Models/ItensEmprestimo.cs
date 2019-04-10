using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Biblioteca.Repositorio;

namespace Biblioteca.Models
{
    public class ItensEmprestimo
    {
        public Livro Livro { get; set; }
        public Emprestimo Emprestimo { get; set; }
        [Required(ErrorMessage = "A data de devolução e obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Data devolução")]
        public DateTime DtDevolucao { get; set; }
        public int Id { get; set; }
        public ItensEmprestimo(Emprestimo emprestimo)
        {
            this.Emprestimo = emprestimo;
        }

        public void Insert()
        {
        }
        public void Update()
        {
        }
        public void Delete()
        {
        }
        public ItensEmprestimo SearchForId(int id)
        {
            ItensEmprestimo itensEmprestimo = new ItensEmprestimo(this.Emprestimo);
            foreach (ItensEmprestimo item in Banco.itensEmprestimos)
            {
                if (item.Id == id)
                {
                    itensEmprestimo = item;
                }
            }
            return itensEmprestimo;
        }
        public IList<ItensEmprestimo> SearchForAll()
        {
            return Banco.itensEmprestimos;
        }
        public ItensEmprestimo SearchForDate(ItensEmprestimo itensEmprestimo)
        {
            ItensEmprestimo itensEmprestimoTRUE = new ItensEmprestimo(this.Emprestimo);
            foreach (ItensEmprestimo item in Banco.itensEmprestimos)
            {
                if (item.DtDevolucao.Date == itensEmprestimo.DtDevolucao.Date)
                {
                    itensEmprestimoTRUE = item;
                }
            }
            return itensEmprestimoTRUE;
        }
    }
}
