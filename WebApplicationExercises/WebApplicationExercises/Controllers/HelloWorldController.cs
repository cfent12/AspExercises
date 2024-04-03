using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationExercises.Controllers
{
    public class HelloWorldController : Controller
    {
        // 첫번째 메서드
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        // GET: HelloWorld/Welcome/
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}