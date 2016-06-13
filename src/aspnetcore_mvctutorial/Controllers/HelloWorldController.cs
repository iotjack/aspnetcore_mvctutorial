using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace aspnetcore_mvctutorial.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/

        public string Index()
        {
            //            return View();
            return "This is my default action...";
        }

        // GET: /HelloWorld/Welcome/ 

        public string Welcome1()
        {
            return "This is the Welcome action method...";
        }

        public string Welcome(string name, int ID = 1)
        {
            //uses HtmlEncoder.Default.Encode to protect the app from malicious input (namely JavaScript).
            return HtmlEncoder.Default.Encode("Hello " + name + ", ID: " + ID);
        }


        //Every public method in a controller is callable as an HTTP endpoint.


    }
}