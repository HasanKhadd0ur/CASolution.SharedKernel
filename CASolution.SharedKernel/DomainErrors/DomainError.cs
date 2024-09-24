using Ardalis.Result;

namespace PSManagement.SharedKernel.DomainErrors
{
    public class DomainError  :ValidationError
    {
        public DomainError(string errorCode, string errorMessage) :base()
        {
            this.ErrorMessage = errorMessage;
            this.ErrorCode = errorCode;
        }

        
    }
}
