using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Day4_SD43_Task.Areas.Finance.Controllers
{
    [HandleError(View ="FinanceErrorPage")]
    public class FinanceController : Controller
    {
        // GET: Finance/Finance
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult geterror1()
        {
            int y = 0;
            int x = 10 / y;

            return View();
        }
        public ActionResult geterror2()
        {
            string y = "asdakjshd";
            int x = int.Parse(y);

            return View();
        }
    }
}