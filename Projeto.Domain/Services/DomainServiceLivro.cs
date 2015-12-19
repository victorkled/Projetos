using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities; //entidades
using Projeto.Domain.Contracts.Repository;
using Projeto.Domain.Contracts.Services;

namespace Projeto.Domain.Services
{
    //classe de negocio para a entidade livro..
    public class DomainServiceLivro 
        : DomainServiceBase<Livro>, IDomainServiceLivro
    {
        //atributo para o repositorio..
        private IRepositoryLivro repositorio;

        public DomainServiceLivro(IRepositoryLivro repositorio)
            : base(repositorio)
        {
            this.repositorio = repositorio;
        }

    }
}
