using Microsoft.AspNetCore.Mvc;

namespace CarWorkshop.MVC.Controllers
{
    public class LogowanieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
