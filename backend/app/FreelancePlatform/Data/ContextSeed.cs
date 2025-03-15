﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreelancePlatform.Models;

namespace FreelancePlatform.Data
{
    public static class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            //Testing
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.SuperAdmin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Freelancer.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Client.ToString()));
        }
        public static async Task SeedSuperAdminAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Default User
            var defaultUser = new ApplicationUser
            {
                UserName = "superadmin",
                Email = "admin@admin.com",
                FirstName = "Filan",
                LastName = "Fisteki",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "P@ssw0rd.");
                    await userManager.AddToRoleAsync(defaultUser, Enums.Roles.SuperAdmin.ToString());
                }

            }
        }
    }
}
