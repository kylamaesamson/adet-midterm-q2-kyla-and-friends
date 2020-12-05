using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationAndAuthorization.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationAndAuthorization.Data
{
    //Contains all the tables

    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<StudentGrades> StudentGrades { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            string ADMIN_ID = "02174cf0–9412–4cfe - afbf - 59f706d72cf6";

            //create user
            var appUser = new AppUser
            {
                Id = ADMIN_ID,
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                FirstName = "admin",
                LastName = "admin",
                UserName = "administrator",
                Role = "Admin",
                NormalizedUserName = "ADMINISTRATOR",
                NormalizedEmail = "ADMIN@GMAIL>COM"
            };

            //set user password
            PasswordHasher<AppUser> ph = new PasswordHasher<AppUser>();
            appUser.PasswordHash = ph.HashPassword(appUser, "password");

            //seed user
            builder.Entity<AppUser>().HasData(appUser);
        }


    }
    
}