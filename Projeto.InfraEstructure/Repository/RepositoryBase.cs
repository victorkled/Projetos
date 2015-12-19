using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Domain.Contracts.Repository;
using Projeto.InfraEstructure.DataSource;
using System.Data.Entity;

namespace Projeto.InfraEstructure.Repository
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity>, IDisposable
        where TEntity : class
    {
        //atributo para a classe de conexão..
        protected Conexao Con;

        //construtor..
        public RepositoryBase()
        {
            //instanciando a classe de conexão..
            Con = new Conexao();
        }

        public void Insert(TEntity obj)
        {
            Con.Entry(obj).State = EntityState.Added;
            Con.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            Con.Entry(obj).State = EntityState.Modified;
            Con.SaveChanges();
        }

        public void Delete(TEntity obj)
        {
            Con.Entry(obj).State = EntityState.Deleted;
            Con.SaveChanges();
        }

        public List<TEntity> FindAll()
        {
            return Con.Set<TEntity>().ToList();
        }

        public TEntity FindById(int Id)
        {
            return Con.Set<TEntity>().Find(Id);
        }

        public void Dispose()
        {
            Con.Dispose();
        }
    }
}
