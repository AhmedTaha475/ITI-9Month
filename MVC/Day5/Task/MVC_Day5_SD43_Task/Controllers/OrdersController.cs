using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_Day5_SD43_Task.Data;
using MVC_Day5_SD43_Task.Models;

namespace MVC_Day5_SD43_Task.Controllers
{
    public class OrdersController : Controller
    {
        private MVC_Day5_SD43_TaskContext db = new MVC_Day5_SD43_TaskContext();

        // GET: Orders
        //[MyCustomerHandler(View = "MyErrorPage")]
        public ActionResult Index()
        {
            ViewBag.customers=db.Customers.ToList();
            var orders = db.Orders.Include(o => o.Customer);
            return View(orders.ToList());
        }
        #region Search With DropDownList
        //[HttpPost]
        //public ActionResult Index(int? custList)
        //{
        //    ViewBag.customers = db.Customers.ToList();
        //    var orders = db.Orders.Where(o => o.custID== custList);
        //    return View(orders.ToList());
        //} 
        #endregion

        [HttpPost]
        [MyCustomerHandler]
        public ActionResult Index(string user)
        {
            ViewBag.customers = db.Customers.ToList();
            var result=db.Customers.Any(c=>c.Name==user);
            if(result)
            {
            var GetUser=db.Customers.Where(c=>c.Name==user).FirstOrDefault();
            var orders = db.Orders.Where(o => o.custID == GetUser.custID);
            return View(orders.ToList());

            }
            else
            {
                throw new Exception("User Doesn't Exist2222");
            }
        }
        // GET: Orders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Orders orders = db.Orders.Find(id);
            if (orders == null)
            {
                return HttpNotFound();
            }
            return View(orders);
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            ViewBag.custID = new SelectList(db.Customers, "custID", "Name");
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Date,TotalPrice,custID")] Orders orders)
        {
            if (ModelState.IsValid)
            {
                db.Orders.Add(orders);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.custID = new SelectList(db.Customers, "custID", "Name", orders.custID);
            return View(orders);
        }

        // GET: Orders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Orders orders = db.Orders.Find(id);
            if (orders == null)
            {
                return HttpNotFound();
            }
            ViewBag.custID = new SelectList(db.Customers, "custID", "Name", orders.custID);
            return View(orders);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Date,TotalPrice,custID")] Orders orders)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orders).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.custID = new SelectList(db.Customers, "custID", "Name", orders.custID);
            return View(orders);
        }

        // GET: Orders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Orders orders = db.Orders.Find(id);
            if (orders == null)
            {
                return HttpNotFound();
            }
            return View(orders);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Orders orders = db.Orders.Find(id);
            db.Orders.Remove(orders);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
