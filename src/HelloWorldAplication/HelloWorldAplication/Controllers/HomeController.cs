using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorldAplication.Models;

namespace HelloWorldAplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var m = new HelloWorldModel()
            {
                Message = "Olá"
            };
            return View(m);
        }
    }
}