using MediatR;

namespace CASolution.SharedKernel.CQRS.Commands
{
    public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
                         where TCommand : ICommand<TResponse>
    {
    }
}
