using SMS_Library.Repositories;
using System.Web.Http;
using Unity;
using Unity.Lifetime;
using Unity.WebApi;

namespace SMS_Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IOrderRepository, OrderRepository>(new HierarchicalLifetimeManager());
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}