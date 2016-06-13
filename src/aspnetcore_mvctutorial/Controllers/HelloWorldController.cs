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

        //public string Index()
        //{
        //    //            return View();
        //    return "This is my default action...";
        //}

        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/ 

        /*public string Welcome()
        {
            return "This is the Welcome action method...";
            //uses HtmlEncoder.Default.Encode to protect the app from malicious input (namely JavaScript).
            return HtmlEncoder.Default.Encode("Hello " + name + ", ID: " + ID);
        }
        */
        public IActionResult Welcome(string name, int numTimes = 1)
        {

            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();

        }


        //Every public method in a controller is callable as an HTTP endpoint.


    }
}