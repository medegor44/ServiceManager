using System.Collections.Generic;
using ServicesManager.Computers;
using ServicesManager.Services;

namespace ServicesManager.MockupNetwork
{
    public class Computer : IComputer
    {
        private Dictionary<string, IService> _services = new Dictionary<string, IService>();

        public Computer(string name, IEnumerable<IService> services)
        {
            Name = name;
            foreach (var service in services)
                _services.Add(service.Name, service);
        }

        public void StopService(string name)
        {
            if (!_services.ContainsKey(name))
                return;

            _services[name].Stop();
        }

        public void RunService(string name)
        {
            if (!_services.ContainsKey(name))
                return;

            _services[name].Run();
        }

        public void RestartService(string name)
        {
            if (!_services.ContainsKey(name))
                return;

            _services[name].Restart();
        }

        public IEnumerable<IService> EnumerateServices()
        {
            return _services.Values;
        }

        public string Name { get; }

        public override bool Equals(object obj)
        {
            if (obj is Computer c)
                return Name == c.Name && _services == c._services;

            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ _services.GetHashCode();
        }
    }
}