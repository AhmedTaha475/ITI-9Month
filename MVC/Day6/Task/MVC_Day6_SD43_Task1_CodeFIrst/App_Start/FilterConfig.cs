using System.Web;
using System.Web.Mvc;

namespace MVC_Day6_SD43_Task1_CodeFIrst
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
