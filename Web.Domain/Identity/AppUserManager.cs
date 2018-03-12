using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Web.Domain.Concrete;

namespace Web.Domain.Identity
{
    public class AppUserManager : UserManager<IdentityUser>
    {
        public AppUserManager(IUserStore<IdentityUser> store) : base(store) { }
        public static AppUserManager Create(IdentityFactoryOptions<AppUserManager> options, IOwinContext context)
        {
            AppUserManager manager = new AppUserManager(new UserStore<IdentityUser>(context.Get<AppDbContext>()));
            manager.PasswordValidator = new PasswordValidator
            {
                RequireDigit = true,//false,
                RequiredLength = 5,
            };
            manager.UserValidator = new UserValidator<IdentityUser>(manager)
            {
                AllowOnlyAlphanumericUserNames = true,
                RequireUniqueEmail = true
            };
            var dataProtectionProvider = options.DataProtectionProvider;
            if (dataProtectionProvider != null)
            {
                manager.UserTokenProvider = new DataProtectorTokenProvider<IdentityUser>(dataProtectionProvider.Create("App"));
            }
            return manager;
        }
    }
}
