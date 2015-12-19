using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Domain.Contracts.Repository;
using Projeto.Domain.Contracts.Services;

namespace Projeto.Domain.Services
{
    //classe para regras de negocio comuns para as demais entidades
    public abstract class DomainServiceBase<TEntity> : IDomainServiceBase<TEntity>
        where TEntity : class
    {
        //atributo para a interface de repositorio...
        private IRepositoryBase<TEntity> repositorio;

        public DomainServiceBase(IRepositoryBase<TEntity> repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Cadastrar(TEntity obj)
        {
            repositorio.Insert(obj);
        }

        public void Atualizar(TEntity obj)
        {
            repositorio.Update(obj);
        }

        public void Excluir(TEntity obj)
        {
            repositorio.Delete(obj);
        }

        public List<TEntity> ListarTodos()
        {
            return repositorio.FindAll();
        }

        public TEntity ObterPorId(int id)
        {
            return repositorio.FindById(id);
        }
    }
}
