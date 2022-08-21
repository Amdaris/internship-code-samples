namespace Factory
{
    public interface ITransporter
    {
        string Name { get; set; }
        float Capacity { get; set; }
        void Deliver();
    }
}
