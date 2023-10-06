using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ReservationApp.Areas.Member.Models;
using System.Threading.Tasks;

namespace ReservationApp.Areas.Member.Controllers
{
	[Area("Member")]
	[Route("Member/[controller]/[action]")]
	public class ProfileController : Controller
	{
		private readonly UserManager<AppUser> userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }

		[HttpGet]
        public async Task<IActionResult> Index()
		{
			var values= await userManager.FindByNameAsync(User.Identity.Name);

			UserEditViewModel userEditViewModel = new UserEditViewModel();
			userEditViewModel.name = values.Name;
			userEditViewModel.lastname = values.Surname;
            userEditViewModel.phonenumber = values.PhoneNumber;
            userEditViewModel.mail = values.Email;

			return View(userEditViewModel);

		}
	}
}
