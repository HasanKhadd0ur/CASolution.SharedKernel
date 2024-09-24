using MediatR;

namespace CASolution.SharedKernel.CQRS.Queries
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }

}
