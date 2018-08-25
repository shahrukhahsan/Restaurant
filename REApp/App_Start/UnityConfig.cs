using System.Web.Http;
using Unity;
using Unity.WebApi;
using RESInterface;
using RESRepository;

namespace REApp
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<ICategoryRepository, CategoryRepository>();
            container.RegisterType<IItemRepository, ItemRepository>();
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IAdminRepository, AdminRepository>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}