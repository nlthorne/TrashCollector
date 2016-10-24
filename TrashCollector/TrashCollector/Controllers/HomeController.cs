using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrashCollector.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My head imploded during this project";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "I don't want you to contact me!!";

            return View();
        }
        public ActionResult MyAccount()
        {
            ViewBag.Message = "Your account page.";

            return View();
        }
    }
}