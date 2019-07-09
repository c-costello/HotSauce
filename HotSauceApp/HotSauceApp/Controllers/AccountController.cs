using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotSauceApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotSauceApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _UserManager;
        private readonly object _SignInManager;

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
    }
}