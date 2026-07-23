namespace DependencyInjectionLifeTime.Services
{
    public class SingletonService : ISingletonService
    {
        private Guid _id;

        public SingletonService()
        {
            _id = Guid.NewGuid();
        }

        public Guid GetId() => _id;
    }
}
