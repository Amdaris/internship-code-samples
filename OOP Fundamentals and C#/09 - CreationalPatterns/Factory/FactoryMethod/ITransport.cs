namespace Factory.FactoryMethod
{
    public interface ITransport
    {
        string Name { get; set; }
        float Capacity { get; set; }
        void Deliver();
    }
}
