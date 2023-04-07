using Microsoft.AspNetCore.Mvc;
using MVC_Day7_SD43_Task.Model;
using System.Linq;

namespace MVC_Day7_SD43_Task.Controllers
{
    public class CarController : Controller
    {
        public IActionResult getall()
        {
            ViewBag.cars = CarList.carList;

            return View();
        }

        public ActionResult SelectCarByID(int id)
        {
            ViewBag.selectedCar = CarList.carList.Where(c => c.Num == id).FirstOrDefault();


            return View();
        }

        public ActionResult CreateNewCar()
        {

            return View();
        }

        [HttpPost]
        public ActionResult CreateNewCar(string num, string color, string model, string man)
        {

            CarList.carList.Add(new Car(int.Parse(num), color, model, man));

            return RedirectToAction("getall");
        }



        public ActionResult UpdateCar(int id)
        {

            ViewBag.selectedCar = CarList.carList.FirstOrDefault(c => c.Num == id);

            return View();
        }

        [HttpPost]
        public ActionResult UpdateCar(int num, string color, string model, string man)
        {

            Car tobeEdited = CarList.carList.FirstOrDefault(c => c.Num == num);
            tobeEdited.Color = color;
            tobeEdited.Model = model;
            tobeEdited.Manufacture = man;

            return RedirectToAction("getall");
        }

        public ActionResult DeleteCar(int id)
        {

            Car selectedCar = CarList.carList.FirstOrDefault(c => c.Num == id);

            CarList.carList.Remove(selectedCar);


            return RedirectToAction("getall");
        }
    }
}
