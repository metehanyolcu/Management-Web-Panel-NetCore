using Microsoft.AspNetCore.Mvc;

namespace MY.MS.Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
