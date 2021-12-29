using Microsoft.AspNetCore.Mvc;

namespace MY.MS.WebProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
