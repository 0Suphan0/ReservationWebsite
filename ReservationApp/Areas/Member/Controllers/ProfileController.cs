using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.Areas.Member.Controllers
{
	public class ProfileController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
