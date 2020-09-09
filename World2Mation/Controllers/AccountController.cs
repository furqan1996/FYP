using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using World2Mation.Models;

namespace World2Mation.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(AdminPortal models)
        {
            using (var context = new World2MationEntities())
            {
                bool isValid = context.Admin.Any(x => x.Name == models.Name && x.Password == models.Password);
                if(isValid)
                {
                    FormsAuthentication.SetAuthCookie(models.Name,false);
                    return RedirectToAction("Index","Users");
                }
                ModelState.AddModelError("", "Invalid Username or Password");
                return View();
            }
                
        }
        //public ActionResult LoginForSecurity()
        //{
        //    return View();
        //}
        //public ActionResult LoginForSecurity(SecurityCentre models)
        //{
        //    return View();
        //}
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(Admin model)
        {
            
            using (var context = new World2MationEntities())
            {
                context.Admin.Add(model);
                context.SaveChanges();

            }
                return RedirectToAction("Login");
        }
        public ActionResult Logout(Admin model)
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}