using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using Application.DAL;
using Application.Domain;
using Microsoft.AspNet.Identity;
using WebApplication1.Identity;
using System;

namespace WebApplication1
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager(), new InjectionConstructor("Mvc5IdentityExample"));
            container.RegisterType<IUserStore<IdentityUser, Guid>, UserStore>(new TransientLifetimeManager());
            container.RegisterType<RoleStore>(new TransientLifetimeManager());

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}