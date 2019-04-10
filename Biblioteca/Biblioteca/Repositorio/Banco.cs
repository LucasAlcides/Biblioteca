using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Repositorio
{
    public class Banco
    {
        public static IList<Aluno> alunos = new List<Aluno>();
        public static IList<Emprestimo> emprestimos = new List<Emprestimo>();
        public static IList<Funcionario> funcionarios = new List<Funcionario>();
        public static IList<ItensEmprestimo> itensEmprestimos = new List<ItensEmprestimo>();
        public static IList<Livro> livros = new List<Livro>();
    }
}
