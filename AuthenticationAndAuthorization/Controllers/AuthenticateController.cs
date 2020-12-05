using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AuthenticationAndAuthorization.Data;
using AuthenticationAndAuthorization.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationAndAuthorization.Controllers
{

    public class AuthenticateController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AuthenticateController(
            AppDbContext db,
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager
        )
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                await _signInManager.SignOutAsync();
                return RedirectToAction("Login");
            };

            return View();
            
        }

        [HttpPost]
        public async Task<IActionResult> Login(string userName, string password)
        {
            //login functionality
            var user = await _userManager.FindByNameAsync(userName);


            if (user != null)
            {
                var role = user.Role;

                //sign in
                var signInResult = await _signInManager.PasswordSignInAsync(user.UserName, password, false, false);

                if (signInResult.Succeeded)
                {
                    if (role == "Admin")
                    {
                        return RedirectToAction("Index", "Admin", new { area = "" });

                    }
                    else if (role == "Student")
                    {

                        return RedirectToAction("Index", "Student", new { area = "" });
                    }

                }
            }

            return View();
        }


        [Authorize(Roles = "Admin")]
        public IActionResult AddStudent()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent(string password, string userName, string firstName, string lastName, string homeAddress,string role)
        {
            //register functionality

           
            

            var user = new AppUser
            {
                FirstName = firstName,
                LastName = lastName,
                Role = role,
                HomeAddress = homeAddress,
                UserName = userName,
            };

            var _password = password;

            var result = await _userManager.CreateAsync(user, _password);

            if (result.Succeeded)
            {
                user = await _userManager.FindByNameAsync(user.UserName);
                
                return RedirectToAction("Index", "Admin", new { area = "" });

            }

            return RedirectToAction("Index", "Admin", new { area = "" });
        }


         


        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }

    }
}
