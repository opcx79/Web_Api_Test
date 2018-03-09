using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Web.Domain.Concrete;

namespace Web.Domain.Identity
{
    public class AppRoleManager : RoleManager<IdentityRole>
    {
        public AppRoleManager(RoleStore<IdentityRole> store) : base(store) { }
        public static AppRoleManager Create(IdentityFactoryOptions<AppRoleManager> options, IOwinContext context)
        {
            return new AppRoleManager(new RoleStore<IdentityRole>(context.Get<AppDbContext>()));
        }
    }
}
