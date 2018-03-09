using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Diagnostics;
using Web.Domain.Identity;

namespace Web.Domain.Concrete
{
    public class AppDbInitializer: CreateDatabaseIfNotExists<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            context.Database.Log = s => Debug.WriteLine(s);

            AppRoleManager roleMgr = new AppRoleManager(new RoleStore<IdentityRole>(context));
            AppUserManager userMgr = new AppUserManager(new UserStore<IdentityUser>(context));

            var AdminUser = userMgr.FindByName("AdminUser");
            if (AdminUser == null)
            {
                userMgr.Create(new IdentityUser
                {
                    UserName = "AdminUser",
                    Email = "admin@cbt.com",
                }, "AdminSecret");
                AdminUser = userMgr.FindByName("AdminUser");
            }

            if (!roleMgr.RoleExists("AdminRole"))
            {
                roleMgr.Create(new IdentityRole("AdminRole"));
            }

            if (!userMgr.IsInRole(AdminUser.Id, "AdminRole"))
                userMgr.AddToRole(AdminUser.Id, "AdminRole");

            base.Seed(context);
        }
    }
}
