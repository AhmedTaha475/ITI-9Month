using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Day4_SD43_Task.Models;
namespace MVC_Day4_SD43_Task.Controllers
{
    //[HandleError(View = "Error2")]
    [Route("")]
    public class HomeController : Controller
    {

        [CustomActionFilter]
        [Route("")]
        public ActionResult Index()
        {
            //int x = 0;
            //int y = 5 / x;
            return View();
        }
        [Route("HassanAboAli")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //int x = 0;
            //int y = 5 / x;


            return View();
        }
        [Route("BoslyHena")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Route("TestError")]
        public ActionResult Error()
        {
            ViewBag.Message = "Your contact page.";

            return View("Error");
        }
    }
}