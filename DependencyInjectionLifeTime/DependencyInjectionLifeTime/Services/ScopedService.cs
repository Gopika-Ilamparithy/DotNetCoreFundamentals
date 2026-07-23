namespace DependencyInjectionLifeTime.Services
{
    public class ScopedService : IScopedService
    {
        private Guid _id;

        public ScopedService()
        {
            _id = Guid.NewGuid();
        }
        public Guid GetId() => _id;
    }
}
