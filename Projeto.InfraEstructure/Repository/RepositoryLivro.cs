using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Domain.Contracts.Repository;
using Projeto.Entities;

namespace Projeto.InfraEstructure.Repository
{
    public class RepositoryLivro
        :  RepositoryBase<Livro>, IRepositoryLivro
    {

    }
}
