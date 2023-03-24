using System.Web;
using System.Web.Mvc;

namespace MVC_Day4_SD43_Task
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new AuthorizeAttribute() );
            filters.Add(new HandleErrorAttribute() { View="Error2"} );
        }
    }
}
