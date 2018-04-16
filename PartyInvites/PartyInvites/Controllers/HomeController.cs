using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    var mvcName = typeof(Controller).Assembly.GetName();
        //    var isMono = Type.GetType("Mono.Runtime") != null;

        //    ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
        //    ViewData["Runtime"] = isMono ? "Mono" : ".NET";

        //    return View();
        //}

        //public String Index() {
        //    return "Hello World";
        //}

        public ViewResult Index() {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }

        public ViewResult RsvpForm() {
            return View();
        }
    }
}
