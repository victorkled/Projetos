using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities; //entidades
using Projeto.Domain.Contracts.Services; //dominio
using Projeto.Application.Contracts; //contratos

namespace Projeto.Application.AppServices
{
    public class AppServiceAutor : AppServiceBase<Autor>, IAppServiceAutor
    {
        //atributo para a camada de dominio..
        private IDomainServiceAutor dominio;

        public AppServiceAutor(IDomainServiceAutor dominio)
            : base(dominio)
        {
            this.dominio = dominio;
        }
    }
}
