using Web.Domain.Concrete;

namespace Web.Domain.Infrastructure
{
    public interface IDbFactory
    {
        AppDbContext Initialize();
    }
}
