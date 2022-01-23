namespace Proptech.Core.Handlers
{
    public interface IAsyncRequestHandler<in TRequest, TResponse> where TRequest: IHandlerRequest<TResponse>
    {
        Task<TResponse> Handle(TRequest request); 
    }
}
