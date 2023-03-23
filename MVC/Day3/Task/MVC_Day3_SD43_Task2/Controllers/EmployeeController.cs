using MVC_Day3_SD43_Task2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Day3_SD43_Task2.Controllers
{
    public class EmployeeController : Controller
    {
        EMPLOYEESEntities context = new EMPLOYEESEntities();
        // GET: Employee
        public ActionResult Index()
        {
             
            return View(context.Emps.ToList());
        }
        [HttpPost]
        public ActionResult Index(string search)
        {

            var list = context.Emps.Where(e=>e.EmpFname==search).ToList();

            return View(list);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.depts=context.Depts.ToList();
            return View(context.Emps.Where(e=>e.EmpID==id).FirstOrDefault());
        }

        // GET: Employee/Create
        public ActionResult Create()
        {

            ViewBag.dept=context.Depts.ToList();
            return View();
        }
        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Emp emp)
        {
            try
            {
                context.Emps.Add(emp);

                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.dept = context.Depts.ToList();
            return View(context.Emps.FirstOrDefault(e => e.EmpID == id));
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Emp emp)
        {
            try
            {
                var selectedEmp = context.Emps.Find(id);
                selectedEmp.EmpFname = emp.EmpFname;
                selectedEmp.EmpLname = emp.EmpLname;
                selectedEmp.EmpSalary = emp.EmpSalary;
                selectedEmp.EmpHDate = emp.EmpHDate;
                selectedEmp.dID= emp.dID;
                selectedEmp.CtyID= emp.CtyID;

                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View(context.Emps.Find(id));
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var selectedEmp = context.Emps.Where(e => e.EmpID==id).FirstOrDefault();
                context.Emps.Remove(selectedEmp);

                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
