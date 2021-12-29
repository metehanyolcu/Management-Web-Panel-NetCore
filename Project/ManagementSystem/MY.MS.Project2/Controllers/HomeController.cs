using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;

namespace MY.MS.Project2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}