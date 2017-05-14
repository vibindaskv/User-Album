using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(User_Albums.Startup))]
namespace User_Albums
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           ConfigureAuth(app);
        }
    }
}
