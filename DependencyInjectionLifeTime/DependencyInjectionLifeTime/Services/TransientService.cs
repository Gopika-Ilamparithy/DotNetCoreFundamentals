namespace DependencyInjectionLifeTime.Services
{
    public class TransientService : ITransientService
    {
        private Guid _id;

        public TransientService()
        {
            _id = Guid.NewGuid();
        }

        public Guid GetId() => _id;
    }
}
