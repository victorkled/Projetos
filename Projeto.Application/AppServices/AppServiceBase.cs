using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Application.Contracts; //interfaces..
using Projeto.Domain.Contracts.Services; //serviços do dominio..

namespace Projeto.Application.AppServices
{
    public abstract class AppServiceBase<TEntity> : IAppServiceBase<TEntity>
        where TEntity : class
    {
        //atributo para a interface do dominio..
        private IDomainServiceBase<TEntity> dominio;

        //construtor
        public AppServiceBase(IDomainServiceBase<TEntity> dominio)
        {
            this.dominio = dominio;
        }

        public void Cadastrar(TEntity obj)
        {
            dominio.Cadastrar(obj);
        }

        public void Atualizar(TEntity obj)
        {
            dominio.Atualizar(obj);
        }

        public void Excluir(TEntity obj)
        {
            dominio.Excluir(obj);
        }

        public List<TEntity> Listar()
        {
            return dominio.ListarTodos();
        }

        public TEntity ObterPorId(int id)
        {
            return dominio.ObterPorId(id);
        }
    }
}
