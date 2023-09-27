using System.Threading.Tasks;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ReservationApp.Models;

namespace ReservationApp.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {

        private readonly UserManager<AppUser> _userManager;

        public LoginController(UserManager<AppUser> userManager)
        {
	        _userManager = userManager;
        }


        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel userRegisterViewModel)
        {
	        AppUser appUser = new AppUser()
	        {
		        Name = userRegisterViewModel.Name,
		        Surname = userRegisterViewModel.Surname,
		        Email = userRegisterViewModel.Mail,
		        UserName = userRegisterViewModel.UserName,

	        };
	        if (userRegisterViewModel.Password == userRegisterViewModel.ConfirmPassword)
	        {
		        var result = await _userManager.CreateAsync(appUser, userRegisterViewModel.Password);

		        if (result.Succeeded)
		        {
			        return RedirectToAction("SignIn");
		        }

                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("",item.Description);
                }
            }

            return View(userRegisterViewModel);
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
    }
}
