using BlogModels.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogModels.Data
{
    public class Seeder
    {
        public static IConfiguration _configuration { get; set; }
        public static DBContext _context { get; set; }
        public static ModelBuilder modelBuilder { get; set; }

        public async Task SeedRole(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("User").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "User";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Admin";
                IdentityResult roleResult = roleManager.CreateAsync(role).Result;

            }
        }

        public async Task SeedUser(UserManager<User> userManager)
        {
            if (userManager.FindByNameAsync("romuald.flouw@student.howest.be").Result == null)
            {
                User user = new User();
                user.UserName = "Romuald";
                user.Email = "romuald.flouw@student.howest.be";
                user.Birthday = DateTime.Now;

                IdentityResult result = userManager.CreateAsync(user, "Romuald@1").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                    userManager.AddToRoleAsync(user, "User").Wait();
                }
            }

            if (userManager.FindByNameAsync("docent@howest.be").Result == null)
            {
                User user = new User();
                user.UserName = "Docent1";
                user.Email = "docent@howest.be";
                user.Birthday = DateTime.Now;

                IdentityResult result = userManager.CreateAsync(user, "Docent@1").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                    userManager.AddToRoleAsync(user, "User").Wait();

                }
            }
            if (userManager.FindByNameAsync("test1@hotmail.com").Result == null)
            {
                User user = new User();
                user.UserName = "TestUser1";
                user.Email = "test1@hotmail.com";
                user.Birthday = DateTime.Now;

                IdentityResult result = userManager.CreateAsync(user, "TestUser@1").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "User").Wait();

                }
            }
            if (userManager.FindByNameAsync("test2@hotmail.com").Result == null)
            {
                User user = new User();
                user.UserName = "TestUser2";
                user.Email = "test2@hotmail.com";
                user.Birthday = DateTime.Now;

                IdentityResult result = userManager.CreateAsync(user, "TestUser@2").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "User").Wait();

                }
            }
        }
    }
}
