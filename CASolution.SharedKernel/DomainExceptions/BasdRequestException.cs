using CASolution.SharedKernel.DomainExceptions.Base;

namespace CASolution.SharedKernel.DomainExceptions
{
    public abstract class BadRequestException : DomainException
    {
        protected BadRequestException(string message)
            : base(message)
        {
        }
    }
}
