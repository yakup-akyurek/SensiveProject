using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SensiveProject.EntityLayer.Concrete;
using SensiveProject.PrensentationLayer.Models;

namespace SensiveProject.PrensentationLayer.Controllers
{
    public class LoginController1 : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController1(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, true);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Category");
            }
            else
            {
                //ModelState.AddModelError("", "Kullanıcı adı veya parola yanlış");
                return View();
            }

        }
    }
}
