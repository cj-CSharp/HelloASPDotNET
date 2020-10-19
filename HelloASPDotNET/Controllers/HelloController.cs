using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        //Get: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/'>" +
                "<input type='text' name='name' />" + 
                "<select name='lang'>" +
                "<option value='english'>English</option>" +
                "<option value='spanish'>Spanish</option>" + 
                "<option value='french'>French</option>" +
                "<option value='thai'>Thai</option>" +
                "<option value='german'>German</option>" +
                "</select>" +
                "<input type='submit' value='greet me!' />" +
                "</form>";
            return Content(html, "text/html");
        }

        //GET: hello/welcome
        //[HttpGet]
        //[Route("/helloworld/welcome/{name?}")]
        [HttpGet("welcome/{name?}")]
        [HttpPost]
        public  IActionResult Welcome(string name = "World", string lang = "english")
        {
            return Content("<h1 style='color:red;'>" + CreateMessage(name, lang) + "!</h1>", "text/html");
        }

        public static string CreateMessage(string name, string lang)
        {
            string hello = "Hello";
            if(lang == "spanish")
            {
                hello = "Hola";
            } else if (lang == "french")
            {
                hello = "Bonjour";
            } else if (lang == "thai")
            {
                hello = "Swasdi";
            } else if (lang == "german")
            {
                hello = "Hallo";
            }
            return $"{hello} {name}";
        }
    }
}
