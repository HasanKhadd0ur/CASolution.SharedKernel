using System.Threading;
using System.Threading.Tasks;

namespace CASolution.SharedKernel.Utilities
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync(CancellationToken cancellationToken = default);
        void BeginTransaction();
        Task Rollback();
    }

}
