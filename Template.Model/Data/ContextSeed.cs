using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Template.Util.Enumerators;
using Template.Model.Models.Admin;

namespace Template.Model.Data
{
    public static class ContextSeed
    {
        public static async Task SeedRolesAsync(UserManager<UserModel> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(Roles.SystemAdministrator.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Developer.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Moderator.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Basic.ToString()));
        }
    }
}
