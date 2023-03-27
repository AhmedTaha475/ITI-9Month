using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Day5_SD43_Task.Models
{
    public class MyCustomerHandler:HandleErrorAttribute
    {

        public override void OnException(ExceptionContext filterContext)
        {

            
            filterContext.ExceptionHandled = true;
            filterContext.Result = new ViewResult
            {
                ViewName = "MyErrorPage",
                MasterName = "_Layout",
                ViewData = new ViewDataDictionary<HandleErrorInfo>(new HandleErrorInfo(filterContext.Exception, 
                filterContext.RouteData.Values["controller"].ToString(), filterContext.RouteData.Values["action"].ToString()))
            };
          
        }
    }
}