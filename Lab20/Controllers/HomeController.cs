using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab20.Models;

namespace Lab20.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Success(Register r)
        {
            ViewBag.Message = "Hello, " + r.FirstName + ". Your email is " + r.Email + ".";
            return View();
        }
    }
}