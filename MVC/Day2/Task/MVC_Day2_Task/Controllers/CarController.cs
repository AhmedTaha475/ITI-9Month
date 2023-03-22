using MVC_Day2_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Day2_Task.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult GetAllCars()
        {

            ViewBag.cars = CarList.List;
            return View();
        }

        public ActionResult SelectCarByID(int id)
        {
            ViewBag.selectedCar = CarList.List.Where(c=>c.Num == id).FirstOrDefault();
            

            return View();
        }

        public ActionResult CreateNewCar()
        {

            return View();
        }

        [HttpPost]
        public ActionResult CreateNewCar(string num,string color,string model,string man)
        {

            CarList.List.Add (new car(int.Parse(num),color,model,man));

            return RedirectToAction("GetAllCars");
        }



        public ActionResult UpdateCar(int id)
        {

            ViewBag.selectedCar=CarList.List.FirstOrDefault(c=>c.Num == id);

            return View();
        }

        [HttpPost]
        public ActionResult UpdateCar(int num, string color, string model, string man)
        {

            car tobeEdited= CarList.List.FirstOrDefault(c=>c.Num == num);
            tobeEdited.Color= color;
            tobeEdited.Model= model;
            tobeEdited.Manfacture= man;

            return RedirectToAction("GetAllCars");
        }

        public ActionResult DeleteCar(int id)
        {

             car selectedCar = CarList.List.FirstOrDefault(c => c.Num == id);

            CarList.List.Remove(selectedCar);


            return RedirectToAction("GetAllCars");
        }





    }
}