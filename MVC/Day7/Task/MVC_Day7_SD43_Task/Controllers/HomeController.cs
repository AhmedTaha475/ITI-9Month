using Microsoft.AspNetCore.Mvc;

namespace MVC_Day7_SD43_Task.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
