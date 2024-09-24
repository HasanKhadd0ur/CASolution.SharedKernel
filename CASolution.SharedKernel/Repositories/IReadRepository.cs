using CASolution.SharedKernel.Entities;
using CASolution.SharedKernel.Utilities;
using System.Collections.Generic;

using System.Threading.Tasks;

namespace CASolution.SharedKernel.Repositories
{
    public interface IReadRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<List<T>> ListAsync();
        Task<List<T>> ListAsync(ISpecification<T> spec);
    }
}
