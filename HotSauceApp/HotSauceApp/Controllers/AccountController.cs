using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotSauceApp.Models;
using HotSauceApp.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotSauceApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _UserManager;
        private readonly SignInManager<ApplicationUser> _SignInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _UserManager = userManager;
            _SignInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel rvm)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser()
                {
                    UserName = rvm.Email,
                    Email = rvm.Email,
                    FirstName = rvm.FirstName,
                    LastName = rvm.LastName,
                    DOB = rvm.DOB,
                };
                var result = await _UserManager.CreateAsync(user, rvm.Password);
                if (result.Succeeded)
                {
                    await _SignInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Shop");
                }
            }
            return View();
        }
    }
}