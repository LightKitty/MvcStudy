using MvcStudy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcStudy.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int Hour = DateTime.Now.Hour;
            ViewBag.Greeting = Hour < 12 ? "Good Morning" : "Good afternoon";
            return View();
        }

        [HttpGet]
        public ViewResult RvspForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RvspForm(GuestResponse guestResponse)
        {
            return View("Thanks", guestResponse);
        }
    }
}