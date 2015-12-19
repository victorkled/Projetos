﻿using Ninject;
using Projeto.Application.AppServices;
using Projeto.Application.Contracts;
using Projeto.Domain.Contracts.Repository;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Services;
using Projeto.InfraEstructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto.Web.App_Start
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver()
        {
            kernel = new StandardKernel();
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            //Nivel da Aplicação
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IAppServiceAutor>().To<AppServiceAutor>();
            kernel.Bind<IAppServiceLivro>().To<AppServiceLivro>();

            //Nivel do dominio
            kernel.Bind(typeof(IDomainServiceBase<>)).To(typeof(DomainServiceBase<>));
            kernel.Bind<IDomainServiceAutor>().To<DomainServiceAutor>();
            kernel.Bind<IDomainServiceLivro>().To<DomainServiceLivro>();

            //Nivel da Repositorio
            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IRepositoryAutor>().To<RepositoryAutor>();
            kernel.Bind<IRepositoryLivro>().To<RepositoryLivro>();
        }
    }
}