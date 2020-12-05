using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationAndAuthorization.Data;
using AuthenticationAndAuthorization.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationAndAuthorization.Controllers
{
    public class AdminController : Controller
    {
        //mich
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AdminController(AppDbContext db, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
        }


        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StudentList()
        {

            return View(_db.AppUsers.ToList());
        }

        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _db.AppUsers.FirstOrDefaultAsync(s => s.Id == id);
            if (student == null)
            {
                return NotFound();
            }


            return View(student);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(string id)
        {
            var student = await _db.AppUsers.FindAsync(id);
            _db.AppUsers.Remove(student);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
  
        }

        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _userManager.FindByIdAsync(id);
            if (id == null)
            {
                return NotFound();
            }

            return View(student);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id,AppUser student)
        {

            var currentAcc = await _userManager.FindByIdAsync(id);
            if (ModelState.IsValid)
            {
                currentAcc.FirstName = student.FirstName;
                currentAcc.LastName = student.LastName;
                currentAcc.HomeAddress = student.HomeAddress;

                _db.Update(currentAcc);
                await _db.SaveChangesAsync();
                //await _userManager.UpdateAsync(student);

                return RedirectToAction("Index");
            }
           
            return View(student);

        }

        [HttpPost]
        public async Task<IActionResult> AddGrade(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _userManager.FindByIdAsync(id);
            var grade = new StudentGrades
            {
                UserID = id
            };

            if (id == null)
            {
                return NotFound();
            }

            return View(grade);
        }

        public async Task<IActionResult> AddGrade(string id, StudentGrades studentGrades)
        {
            if (ModelState.IsValid)
            {
                studentGrades.PrelimGrade =
                    ((studentGrades.Quiz1Prelim + studentGrades.Quiz2Prelim + studentGrades.Quiz3Prelim)
                    +(studentGrades.Assignment1Prelim + studentGrades.Assignment2Prelim + studentGrades.Assignment3Prelim))
                    /6;
                studentGrades.MidtermGrade =
                    ((studentGrades.Quiz1Midterm + studentGrades.Quiz2Midterm + studentGrades.Quiz3Midterm)
                    + (studentGrades.Assignment1Midterm + studentGrades.Assignment2Midterm + studentGrades.Assignment3Midterm))
                    / 6;
                studentGrades.PrefinalGrade =
                    ((studentGrades.Quiz1Prefinal + studentGrades.Quiz2Prefinal + studentGrades.Quiz3Prefinal)
                    + (studentGrades.Assignment1Prefinal + studentGrades.Assignment2Prefinal + studentGrades.Assignment3Prefinal))
                    / 6;
                studentGrades.PrelimGrade = 
                    ((studentGrades.Quiz1Final + studentGrades.Quiz2Final + studentGrades.Quiz3Final)
                    + (studentGrades.Assignment1Final + studentGrades.Assignment2Final + studentGrades.Assignment3Final))
                    / 6;



                await _db.StudentGrades.AddAsync(studentGrades);
                await _db.SaveChangesAsync();

                return RedirectToAction("StudentList");
            }
        
            return View();
        }

        //mich

    }
}
