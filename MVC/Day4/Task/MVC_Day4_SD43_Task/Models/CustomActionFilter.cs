using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Day4_SD43_Task.Models
{
    public class CustomActionFilter : ActionFilterAttribute /*Attribute, IActionFilter, IResultFilter*/
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("On action executed");
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("On action executing");
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Debug.WriteLine("On Result executed");
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            
            Debug.WriteLine("On action executing");
        }
    }
}