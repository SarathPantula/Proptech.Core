namespace Proptech.Core.Validators
{
    public interface IAsyncRequestValidator<in TRequest, TResponse> where TRequest : IValidatorRequest<TResponse>
    {
        Task<TResponse> Validate(TRequest request);
    }
}
