using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Day6_SD43_Task2_ExternalLogin.Startup))]
namespace MVC_Day6_SD43_Task2_ExternalLogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
