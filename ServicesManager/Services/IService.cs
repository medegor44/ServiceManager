namespace ServicesManager.Services
{
    public interface IService
    {
        string Name { get; }
        ServiceState State { get; }
        void Stop();
        void Run();
        void Restart();
    }
}