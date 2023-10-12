using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ReservationApp.Areas.Member.Models;
using System;
using System.IO;
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

		[HttpPost]
		public async Task<IActionResult> Index(UserEditViewModel userEditViewModel)
		{
			var user = await userManager.FindByNameAsync(User.Identity.Name);

			if (userEditViewModel.Image != null)
			{
				var resource = Directory.GetCurrentDirectory();
				var extension = Path.GetExtension(userEditViewModel.Image.FileName);
				var imageName = Guid.NewGuid() + extension;
				var saveLocation=resource + "/wwwroot/userimages/"+ imageName;
				var stream = new FileStream(saveLocation, FileMode.Create);
				await userEditViewModel.Image.CopyToAsync(stream);
                user.ImageUrl = "/userimages/" + imageName;
            }
			user.Name = userEditViewModel.name;
			user.Surname = userEditViewModel.lastname;
			user.PasswordHash = userManager.PasswordHasher.HashPassword(user, userEditViewModel.password);
			var result=await userManager.UpdateAsync(user);
			if(result.Succeeded)
			{
				return RedirectToAction("SignIn", "Login");
			}
			return View();
		}

	}
}
