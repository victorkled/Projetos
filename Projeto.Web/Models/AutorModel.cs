using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; //mapeamento

namespace Projeto.Web.Models
{
    public class AutorViewModelCadastro
    {
        [Required(ErrorMessage = "Por favor, informe o nome do autor.")]
        [MinLength(6, ErrorMessage = "Erro. Nome do Autor deve ter no minimo 6 caracteres.")]
        [MaxLength(50, ErrorMessage = "Erro. Nome do Autor deve ter no máximo 50 caracteres.")]
        [Display(Name = "Nome do Autor:")]
        public string Nome { get; set; }
    }

    public class AutorViewModelConsulta
    {
        public int IdAutor { get; set; }
        public string Nome { get; set; }
    }

    public class AutorViewModelEdicao
    {
        public int IdAutor { get; set; }

        [Required(ErrorMessage = "Por favor, informe o nome do autor.")]
        [MinLength(6, ErrorMessage = "Erro. Nome do Autor deve ter no minimo 6 caracteres.")]
        [MaxLength(50, ErrorMessage = "Erro. Nome do Autor deve ter no máximo 50 caracteres.")]
        [Display(Name = "Nome do Autor:")]
        public string Nome { get; set; }

    }
}