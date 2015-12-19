using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities; //entidades
using Projeto.Domain.Contracts.Services; //serviços
using Projeto.Application.Contracts; //contratos

namespace Projeto.Application.AppServices
{
    public class AppServiceLivro : AppServiceBase<Livro>, IAppServiceLivro
    {
        //atributo da camada de dominio
        private IDomainServiceLivro dominio;

        public AppServiceLivro(IDomainServiceLivro dominio)
            : base(dominio)
        {
            this.dominio = dominio;
        }
    }
}
