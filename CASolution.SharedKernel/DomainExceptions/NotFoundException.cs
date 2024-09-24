using CASolution.SharedKernel.DomainExceptions.Base;

namespace CASolution.SharedKernel.DomainExceptions
{
    public abstract class NotFoundException : DomainException
    {
        protected NotFoundException(string message)
            : base(message)
        {
        }
    }
}

