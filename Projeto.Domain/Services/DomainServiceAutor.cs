using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities; //entidades..
using Projeto.Domain.Contracts.Repository;
using Projeto.Domain.Contracts.Services;

namespace Projeto.Domain.Services
{
    //classe de negocio para a entidade autor..
    public class DomainServiceAutor
        : DomainServiceBase<Autor>, IDomainServiceAutor
    {
        //repositorio..
        private IRepositoryAutor repositorio;

        public DomainServiceAutor(IRepositoryAutor repositorio)
            : base(repositorio)
        {
            this.repositorio = repositorio;
        }
    }
}
