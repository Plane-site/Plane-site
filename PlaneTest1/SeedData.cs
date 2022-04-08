using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plane
{
	public class SeedData
	{
		public static void Seed(UserManager<IdentityUser> userManager,
			RoleManager<IdentityRole> roleManager)//Pravi vrazkata
		{
			SeedRoles(roleManager);
			SeedUsers(userManager);
		}
		public static void SeedUsers(UserManager<IdentityUser> userManager)
		{
			if (userManager.FindByNameAsync("admin").Result == null)//Pravi admin s opredeleni stoinosti i mu raga rolq
			{
				var user = new IdentityUser
				{
					UserName = "admin@localhost",
	                Email = "admin@localhost",
					EmailConfirmed = true
				};
				var result = userManager.CreateAsync(user, "P@assword1").Result;
				if (result.Succeeded)
				{
					userManager.AddToRoleAsync(user, "Administrator").Wait();
				}
			}
		}
		public static void SeedRoles(RoleManager<IdentityRole> roleManager)
		{
			if (!roleManager.RoleExistsAsync("Administrator").Result)//proveravq dali ima rolq i ako nqma q pravi

			{
				var role = new IdentityRole
				{
					Name = "Administrator"
				};
				var result = roleManager.CreateAsync(role).Result;
			}
			if (!roleManager.RoleExistsAsync("User").Result)//proveravq dali ima rolq i ako nqma q pravi

			{
				var role = new IdentityRole
				{
					Name = "User"
				};
				var result = roleManager.CreateAsync(role).Result;
			}
		}
	}
}