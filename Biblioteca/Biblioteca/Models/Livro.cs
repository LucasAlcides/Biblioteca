using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Biblioteca.Repositorio;

namespace Biblioteca.Models
{
    public class Livro
    {
        [Required(ErrorMessage = "Nome do autor e obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Informe o Autor")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "A data da publicação e obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Informe a data da publicação")]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public DateTime DtPublicacao { get; set; }
        [Required(ErrorMessage = "Nome da editora obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Informe a editora")]
        public string Editora { get; set; }
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome do titulo obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Informe o titulo")]
        public string Titulo { get; set; }


        public void Insert()
        {
                Random r = new Random();
                this.Id = r.Next(1, 9999);
                Banco.livros.Add(this);
        }
        public void Update()
        {
			Livro livro = Banco.livros.First(x => x.Id == this.Id);
            livro.Titulo = this.Titulo;
            livro.Editora = this.Editora;
            livro.DtPublicacao = this.DtPublicacao;
            livro.Autor = this.Autor;
        }
        public void Delete()
        {
            Livro livro = Banco.livros.First(Livro => Livro.Id == this.Id);
			Banco.livros.Remove(livro);
        }
        public Livro SearchForId(int id)
        {
            return Banco.livros.FirstOrDefault(x => x.Id == id);
        }
        public IList<Livro> SearchForAll()
        {
            return Banco.livros;
        }
        
    }
}
