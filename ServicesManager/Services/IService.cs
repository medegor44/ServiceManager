namespace ServicesManager.Services
{
    public interface IService
    {
        string Name { get; }
        void Stop();
        void Run();
        void Restart();
    }
}