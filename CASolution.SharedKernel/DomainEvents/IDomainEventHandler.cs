using MediatR;

namespace CASolution.SharedKernel.DomainEvents
{
    public interface IDomainEventHandler<T> : INotificationHandler<T> where T : IDomainEvent
    {
    }
}
