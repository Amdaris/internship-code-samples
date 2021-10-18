namespace MediatorPattern
{
    public interface IRequestHandler<in T> where T : IRequest
    {
        void Handle(T request);
    }
}
