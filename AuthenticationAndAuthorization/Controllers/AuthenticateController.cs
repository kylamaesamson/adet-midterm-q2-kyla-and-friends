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
    //Kyla  
    public class AuthenticateController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly AppDbContext _appDbContext;

        public AuthenticateController(
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            AppDbContext appDbContext
        )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _appDbContext = appDbContext;
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
        public async Task<IActionResult> AddStudent(string password, string userName, string firstName, string lastName, string homeAddress)
        {
            //register functionality

           
            

            var user = new AppUser
            {
                FirstName = firstName,
                LastName = lastName,
                HomeAddress = homeAddress,
                UserName = userName,
                Role = "Student"
            };

            var _password = password;

            var result = await _userManager.CreateAsync(user, _password);

            if (result.Succeeded)
            {
                user = await _userManager.FindByNameAsync(user.UserName);

                var prelim = InitializeGrades("Prelim");
                var midterm = InitializeGrades("Midterm");
                var preFinal = InitializeGrades("Prefinal");
                var final = InitializeGrades("Final");
                await _appDbContext.AddRangeAsync(prelim,midterm,preFinal,final);
                await _appDbContext.SaveChangesAsync();

                var grade = new StudentGrades
                {
                    AppUserID = user.Id,
                    PrelimID = prelim.ID,
                    MidtermID = midterm.ID,
                    PrefinalID = preFinal.ID,
                    FinalID = final.ID
                };

                await _appDbContext.AddAsync(grade);
                await _appDbContext.SaveChangesAsync();
            }
            return RedirectToAction("Index", "Admin", new { area = "" });
        }

        public GradesPerTerm InitializeGrades(string term)
        {
            var gpt = new GradesPerTerm
            {
                Term = term,
                Grade = 0
            };
            string[] types = {"Quiz1","Quiz2","Quiz3","Assignment1","Assignment2","Assignment3" };
            
            var item = new ItemScore();
            for (int i = 0; i < types.Length; i++)
            {
                item = new ItemScore
                {
                    TotalItems = 0,
                    Score = 0,
                    Grade = 0,
                    Type = types[i]
                };

                _appDbContext.Add(item);
                _appDbContext.SaveChanges();

                switch (i)
                {
                    case 0:
                        gpt.Quiz1ID = item.ID;
                        break;
                    case 1:
                        gpt.Quiz2ID = item.ID;
                        break;
                    case 2:
                        gpt.Quiz3ID = item.ID;
                        break;
                    case 3:
                        gpt.Assignment1ID = item.ID;
                        break;
                    case 4:
                        gpt.Assignment2ID = item.ID;
                        break;
                    case 5:
                        gpt.Assignment3ID = item.ID;
                        break;
                    default:
                        break;
                }

            }

            return gpt;
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }

    }
    //Kyla
}
