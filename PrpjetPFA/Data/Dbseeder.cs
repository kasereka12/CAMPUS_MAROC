using PrpjetPFA.Constants;
using Microsoft.AspNetCore.Identity;

namespace PrpjetPFA.Data
{
    public class Dbseeder
    {
        public static async Task SeedDefaultData(IServiceProvider service)
        {
            var userMgr = service.GetService<UserManager<IdentityUser>>();
            var roleMgr = service.GetService<RoleManager<IdentityRole>>();

            await roleMgr.CreateAsync(new IdentityRole(Roles.User));
            await roleMgr.CreateAsync(new IdentityRole(Roles.Admin));





        }

    }
}
