using System.Threading.Tasks;
using Web.Domain.Concrete;

namespace Web.Domain.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private AppDbContext dbContext;

        public AppDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Initialize()); }
        }

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await DbContext.SaveChangesAsync();
        }
    }
}
