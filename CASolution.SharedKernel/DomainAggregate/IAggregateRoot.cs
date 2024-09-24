using CASolution.SharedKernel.Entities;

namespace CASolution.SharedKernel.DomainAggregate
{
    // Apply this marker interface only to aggregate root entities
    // Repositories will only work with aggregate roots, not their children
    public class IAggregateRoot : BaseEntity
    {
    }
}
