using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.Areas.Member.Controllers
{
	public class MessageController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
