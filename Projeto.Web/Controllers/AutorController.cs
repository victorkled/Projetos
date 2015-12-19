using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto.Web.Models; //camada de modelo..
using Projeto.Application.Contracts; //interfaces
using Projeto.Entities; //entidades

namespace Projeto.Web.Controllers
{
    public class AutorController : Controller
    {        
        //atributo..
        private IAppServiceAutor appAutor; //null

        //construtor..
        public AutorController(IAppServiceAutor appAutor)
        {
            this.appAutor = appAutor;
        }


        // GET: /Autor/Cadastro
        public ActionResult Cadastro()
        {
            return View();
        }

        // GET: /Autor/Consulta
        public ActionResult Consulta()
        {
            return View(ListarAutores());
        }


        // GET: /Autor/CadastrarAutor
        [HttpPost]
        public ActionResult CadastrarAutor(AutorViewModelCadastro model)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    Autor a = new Autor();
                    a.Nome = model.Nome;

                    appAutor.Cadastrar(a); //aplicação..

                    ModelState.Clear();
                    ViewBag.Mensagem = "Autor " + a.Nome + ", cadastrado com sucesso.";
                }
                catch(Exception e)
                {
                    ViewBag.Mensagem = e.Message;
                }
            }

            return View("Cadastro"); //nome da página..
        }


        private List<AutorViewModelConsulta> ListarAutores()
        {
            var lista = new List<AutorViewModelConsulta>();

            try
            {

                foreach(Autor a in appAutor.Listar())
                {
                    var model = new AutorViewModelConsulta();

                    model.IdAutor = a.IdAutor;
                    model.Nome = a.Nome;

                    lista.Add(model);
                    
                }

            }
            catch(Exception e)
            {
                ViewBag.Mensagem = e.Message;
            }

            return lista;
        }

	}
    
}