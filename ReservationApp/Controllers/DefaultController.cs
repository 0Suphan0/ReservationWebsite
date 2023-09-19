using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
