using System.Threading.Tasks;

namespace Web.Domain.Infrastructure
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
    }
}
