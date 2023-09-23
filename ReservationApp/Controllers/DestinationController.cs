using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.Controllers
{
    public class DestinationController : Controller
    {
        private DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());

        public IActionResult Index()
        {
            var values=destinationManager.GetAll();
            return View(values);
        }
    }
}
