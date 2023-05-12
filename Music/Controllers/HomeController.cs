using Microsoft.AspNetCore.Mvc;

namespace Music.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
