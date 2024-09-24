namespace CASolution.SharedKernel.CQRS.Queries
{
    public interface ILoggableQuery<out TResponse> : IQuery<TResponse>
    {
    }

}
