using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using User_Albums.Business;
using User_Albums.Utilities;

namespace User_Albums
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IUserAlbumService, UserAlbumService>();
            container.RegisterType<IHttpUtility,HttpUtlity>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}