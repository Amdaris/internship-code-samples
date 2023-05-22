namespace Factory.FactoryMethod
{
    public interface ITransport
    {
        string Name { get; set; }
        float Capacity { get; set; }

        bool CheckDeliveryPermission();
        void Deliver();
        string GetTransportInformation();
    }
}
