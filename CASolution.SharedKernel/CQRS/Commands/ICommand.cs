using MediatR;

namespace CASolution.SharedKernel.CQRS.Commands
{
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}
