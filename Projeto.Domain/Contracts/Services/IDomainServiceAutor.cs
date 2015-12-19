using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities; //entidades

namespace Projeto.Domain.Contracts.Services
{
    public interface IDomainServiceAutor
        : IDomainServiceBase<Autor>
    {

    }
}
