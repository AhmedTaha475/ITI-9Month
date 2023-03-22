using MVC_Day2_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Day2_Task.Controllers
{
    public class ImageController : Controller
    {
        // GET: Image
        public ActionResult FillForm()
        {

            ViewBag.imgs = ImageList.images;
            return View();
        }

        public ActionResult ResultView(string id,string name,string img)
        {

            ViewBag.Data =new imageClass(id,name,img);   
            return View();
        }
    }
}