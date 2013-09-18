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

        public string Index()
        {
            return "This is default action";
        }

        public string Welcome(string name, int age)
        {
            return "Hello, " + name + ". Your age must be " + age;
        }

    }
}
