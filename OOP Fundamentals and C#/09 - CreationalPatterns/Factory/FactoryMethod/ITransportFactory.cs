namespace Factory.FactoryMethod
{
    public interface ITransportFactory
    {
        ITransport CreateTransport(float capacity, string name);

        void DispatchTransport(float capacity);
    }
}
