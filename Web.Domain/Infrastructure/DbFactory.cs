using Web.Domain.Concrete;

namespace Web.Domain.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        AppDbContext dbContext;

        public AppDbContext Initialize()
        {
            return dbContext ?? (dbContext = new AppDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
