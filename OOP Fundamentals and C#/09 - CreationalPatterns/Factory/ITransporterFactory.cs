namespace Factory
{
    public interface ITransporterFactory
    {
        ITransporter CreateTransporter(float capacity, string name);
    }
}
