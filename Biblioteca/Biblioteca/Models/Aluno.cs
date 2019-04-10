using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Biblioteca.Repositorio;

namespace Biblioteca.Models
{
    public class Aluno : Pessoa
    {
        [Required(ErrorMessage = "Nome da Cidade e obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome da sua Cidade", Description = "Ex: Porto Velho.")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Data de Nascimento e obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Informe sua data", Description = "Data de Nascimento")]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        public DateTime DataNascimento { get; set; }
        [Required(ErrorMessage = "Numero e obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Informe o seu numero", Description = "Celular.")]
        [StringLength(10, MinimumLength = 8)]
        public string Numero { get; set; }
        [Required(ErrorMessage = "Orgão Expedidor e obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome do Orgão", Description = "Orgão Expedidor.")]
        public string OrgaoExpedidor { get; set; }
        [Required(ErrorMessage = "RG e obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Informe o RG", Description = "RG completo.")]
        [StringLength(9, MinimumLength = 9)]
        public string Rg { get; set; }
        [Required(ErrorMessage = "Nome da rua e obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome da sua Rua", Description = "Ex: Rua do Jose.")]
        public string Rua { get; set; }
        [Required(ErrorMessage = "Sexo e obrigatório", AllowEmptyStrings = false)]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "UF e obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Informe o UF", Description = "Unidade da Federação.")]
        public string Uf { get; set; }


        public void Insert()
        {
            Random r = new Random();
            this.Id = r.Next(1, 9999);
            Banco.alunos.Add(this);
        }
        public void Update()
        {
            Aluno aluno = Banco.alunos.First(x => x.Id == this.Id);
            aluno.Nome = this.Nome;
            aluno.Numero = this.Numero;
            aluno.OrgaoExpedidor = this.OrgaoExpedidor;
            aluno.Rg = this.Rg;
            aluno.Rua = this.Rua;
            aluno.Sexo = this.Sexo;
            aluno.Uf = this.Uf;
        }
        public void Delete()
        {
            Aluno aluno = Banco.alunos.First(Aluno => Aluno.Id == this.Id);
            Banco.alunos.Remove(aluno);  
        }
        public Aluno SearchForId(int id)
        {
            return Banco.alunos.FirstOrDefault(x => x.Id == id);
            
        }
        public IList<Aluno> SearchForAll()
        {
            return Banco.alunos;
        }
       
    }
}
