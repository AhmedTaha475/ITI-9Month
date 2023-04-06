using MVC_Day6_SD43_Task1_CodeFIrst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace MVC_Day6_SD43_Task1_CodeFIrst.Controllers
{
    [AllowAnonymous]
    public class ClientController : Controller
    {
        IdentityContext Context = new IdentityContext();
        // GET: Client
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Client client)
        {

            if(ModelState.IsValid)
            {
                Context.Clients.Add(client);
                Context.SaveChanges();

                var ClientIdentity = new ClaimsIdentity(new List<Claim>()
                {
                    new Claim("Name", client.Name),
                    new Claim(ClaimTypes.Email, client.Email),
                    new Claim("Password", client.Password)
                }, "AppCookie");

                Request.GetOwinContext().Authentication.SignIn(ClientIdentity);
                 
                return RedirectToAction("Index","Home");
            }


            return View();
        }


        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Client client)
        {

            var loggedClient = Context.Clients.FirstOrDefault(
                 u => u.Email == client.Email && u.Password == client.Password);

            if (loggedClient != null)
            {
                var signInIdentity = new ClaimsIdentity(new List<Claim>()
                {
                    new Claim(ClaimTypes.Email, client.Email),
                    new Claim("Password", client.Password)
                }, "AppCookie");

                //Owin Authentication manager
                Request.GetOwinContext().Authentication.SignIn(signInIdentity);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("Name", "Client Doesn't Exist");

                return View();
            }
        }


        public ActionResult Logout()
        {
            Request.GetOwinContext().Authentication.SignOut("AppCookie");
            return RedirectToAction("Login");
        }
    }
}