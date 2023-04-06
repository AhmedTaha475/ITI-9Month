using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(MVC_Day6_SD43_Task1_CodeFIrst.Startup1))]

namespace MVC_Day6_SD43_Task1_CodeFIrst
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new Microsoft.Owin.Security.Cookies.CookieAuthenticationOptions()
            {
                AuthenticationType = "AppCookie",
                LoginPath = new PathString("/Client/Login")
            }
           );
        }
    }
}
