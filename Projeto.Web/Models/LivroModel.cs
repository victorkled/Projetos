using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projeto.Entities.Types; //enum
using System.ComponentModel.DataAnnotations; //mapeamento..
using System.Web.Mvc;

namespace Projeto.Web.Models
{
    public class LivroViewModelCadastro
    {
        [Required(ErrorMessage = "Por favor, informe o titulo do livro.")]
        [Display(Name = "Titulo do Livro:")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Por favor, informe o resumo do livro.")]
        [Display(Name = "Resumo do Livro:")]
        public string Resumo { get; set; }

        [Required(ErrorMessage = "Por favor, envie a foto do livro.")]
        [Display(Name = "Envie a Foto:")]
        public HttpPostedFileBase Foto { get; set; }

        [Required(ErrorMessage = "Por favor, selecione a categoria do livro.")]
        [Display(Name = "Selecione a Categoria:")]
        public Categoria Categoria { get; set; }

        [Required(ErrorMessage = "Por favor, selecione o autor do livro.")]
        [Display(Name = "Selecione o Autor:")]
        public List<SelectListItem> Autores { get; set; }
    }

    public class LivroViewModelConsulta
    {
        public int IdLivro { get; set; }
        public string Titulo { get; set; }
        public string Resumo { get; set; }
        public string Categoria { get; set; }
        public string Foto { get; set; }
        public string Autor { get; set; }
    }
}