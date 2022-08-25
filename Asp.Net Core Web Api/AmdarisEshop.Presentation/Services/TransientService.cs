namespace AmdarisEshop.Presentation.Services
{
    public class TransientService : ITransientService
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
    }
}
