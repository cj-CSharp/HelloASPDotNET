using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET.Controllers
{
    public class HelloController : Controller
    {
        //Get: /<controller>/
        [HttpGet]
        [Route("/helloworld/")]
        public IActionResult Index()
        {
            string html = "<h1>Hello World!</h1>";
            return Content(html, "text/html");
        }

        //GET: hello/welcome
        [HttpGet]
        [Route("/helloworld/welcome/{name?}")]
        public  IActionResult Welcome(string name = "World")
        {
            return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        }
    }
}
