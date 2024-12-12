using System.Diagnostics;
using System.Reflection;
using Domain;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Order_Management.Models;

namespace Order_Management.Controllers
{
    public class HomeController(
        ILogger<HomeController> logger,
        IValidator<Login> loginValidationRules,
        IValidator<SignUp> signUpValidationRules
        ) : Controller
    {
        private readonly ILogger<HomeController> _logger = logger;
        //private readonly LoginValidator _loginValidationRules = loginValidationRules;
        private readonly IValidator<Login> _loginValidationRules = loginValidationRules;
        private readonly IValidator<SignUp> _signUpValidationRules = signUpValidationRules;


        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(Login login)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index", "Home");
                    //var result = await _signInManager.PasswordSignInAsync(login.Username, login.Password, login.RememberMe, lockoutOnFailure: false);
                    //if (result.Succeeded)
                    //{
                    //    return RedirectToAction("Index", "Home");
                    //}
                    //ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                }
            }
            catch (Exception ex)
            {
                _ = ex.ToString();
            }
            return View(login);
        }

        // Logout  
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            //await _signInManager.SignOutAsync();
            return RedirectToAction("SignIn", "Home");
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUp signUp)
        {
            try
            {
                //var user = new ApplicationUser { UserName = signUp.UserName, Email = signUp.EmailAddress };
                //var result = await _userManager.CreateAsync(user, signUp.Password);
                //if (result.Succeeded)
                //{
                //    await _signInManager.SignInAsync(user, isPersistent: false);
                //    return RedirectToAction("Index", "Home");
                //}
                //foreach (var error in result.Errors)
                //{
                //    ModelState.AddModelError(string.Empty, error.Description);
                //}
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception ex)
            {
                _ = ex.ToString();
            }
            return View(signUp);
        }

        public IActionResult Reset()
        {
            return View();
        }

        public IActionResult Lock()
        {
            return View();
        }
    }
}
