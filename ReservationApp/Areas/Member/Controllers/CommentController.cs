using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ReservationApp.Areas.Member.Controllers
{
	[AllowAnonymous]
	[Area("Member")]
	public class CommentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
