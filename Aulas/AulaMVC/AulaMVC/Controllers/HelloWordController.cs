using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace AulaMVC.Controllers
{
    public class HelloWordController : Controller
    {
        public string Index()
        {
            return "Minha ação padrão";
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
