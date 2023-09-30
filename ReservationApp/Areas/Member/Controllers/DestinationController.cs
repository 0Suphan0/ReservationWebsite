using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.Areas.Member.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        private DestinationManager _destinationManager = new DestinationManager(new EfDestinationDal());


        [Area("Member")]

        public IActionResult Index()
        {
            var values = _destinationManager.GetAll();
            return View(values);
        }
    }
}
