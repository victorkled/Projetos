using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto.Web.Models; //camada de modelo..
using Projeto.Application.Contracts; //contratos

namespace Projeto.Web.Controllers
{
    public class LivroController : Controller
    {
        private IAppServiceLivro appLivro;

        public LivroController(IAppServiceLivro appLivro)
        {
            this.appLivro = appLivro;
        }

        // GET: /Livro/Cadastro
        public ActionResult Cadastro()
        {
            return View();
        }

        // GET: /Livro/Consulta
        public ActionResult Consulta()
        {
            return View();
        }
	}
}