namespace ServicesManager.Computers
{
    public interface IComputer
    {
        void StopService(string name);
        void RunService(string name);
        void RestartService(string name);
        string Name { get; }
    }
}