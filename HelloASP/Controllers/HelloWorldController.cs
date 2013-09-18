using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloASP.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string str, int times)
        {
            ViewBag.String = str;
            ViewBag.Times = times;

            return View();
        }

    }
}
