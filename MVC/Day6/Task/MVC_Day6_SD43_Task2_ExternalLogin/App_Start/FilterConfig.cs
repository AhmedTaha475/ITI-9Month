using System.Web;
using System.Web.Mvc;

namespace MVC_Day6_SD43_Task2_ExternalLogin
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
