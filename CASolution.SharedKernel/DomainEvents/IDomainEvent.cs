using MediatR;
using System;

namespace CASolution.SharedKernel.DomainEvents
{
    public interface IDomainEvent : INotification
    {
        public DateTime DateOccurred { get; set; }

    }
}
