using System.Collections.Generic;
using ServicesManager.Computers;
using ServicesManager.Providers;

namespace ServicesManager
{
    public class ServiceManager
    {
        private Dictionary<string, IComputer> Computers { get; } = new Dictionary<string, IComputer>();
        private IProvider Provider { get; }

        public ServiceManager(IProvider provider)
        {
            Provider = provider;
        }

        public void AddComputer(string computerName)
        {
            AddComputer(Provider.FindComputer(computerName));
        }

        public void RemoveComputer(string computerName)
        {
            Computers.Remove(computerName);
        }

        private void AddComputer(IComputer computer)
        {
            Computers.Add(computer.Name, computer);
        }

        public void StopServiceAt(string computerName, string serviceName)
        {
            if (!Computers.ContainsKey(computerName))
                return;

            Computers[computerName].StopService(serviceName);
        }

        public void RunServiceAt(string computerName, string serviceName)
        {
            if (!Computers.ContainsKey(computerName))
                return;

            Computers[computerName].RunService(serviceName);
        }

        public void RestartServiceAt(string computerName, string serviceName)
        {
            if (!Computers.ContainsKey(computerName))
                return;

            Computers[computerName].RestartService(serviceName);
        }
    }
}