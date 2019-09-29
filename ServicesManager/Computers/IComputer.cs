using System.Collections.Generic;
using ServicesManager.Services;

namespace ServicesManager.Computers
{
    public interface IComputer
    {
        void StopService(string name);
        void RunService(string name);
        void RestartService(string name);
        IEnumerable<IService> EnumerateServices();
        string Name { get; }
    }
}