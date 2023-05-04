using Dto;
using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.Models;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public HomeController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GirisYap()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> GirisYap(AppUserSignInViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    var identityResult = await _signInManager.PasswordSignInAsync(user.UserName, model.Password, model.RememberMe, false);
                    if (identityResult.Succeeded)
                    {
                        //var roller = await _userManager.GetRolesAsync(user);

                        //if (roller.Contains("Admin"))
                        //{
                        //    return RedirectToAction("Index", "Home", new { area = "Admin" });
                        //}
                        //else
                        //{
                        //    return RedirectToAction("Index", "Home", new { area = "Member" });
                        //}
                        return RedirectToAction("Index", "Home");
                    }
                }
                ModelState.AddModelError("", "Kullanıcı Adı veya Şifre Hatalı");
            }
            return View();
        }
        public async Task<IActionResult> CikisYap()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("GirisYap");
        }
    }
}