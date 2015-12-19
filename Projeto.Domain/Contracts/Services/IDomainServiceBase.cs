﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain.Contracts.Services
{
    //interface para as regras de negócio genericas..
    public interface IDomainServiceBase<TEntity>
        where TEntity : class
    {
        void Cadastrar(TEntity obj);
        void Atualizar(TEntity obj);
        void Excluir(TEntity obj);
        List<TEntity> ListarTodos();
        TEntity ObterPorId(int id);
    }
}
