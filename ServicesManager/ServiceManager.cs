﻿using System.Collections.Generic;
using ServicesManager.Computers;
using ServicesManager.Providers;

namespace ServicesManager
{
    public class ServiceManager
    {
        private Dictionary<string, IComputer> _computers = new Dictionary<string, IComputer>();
        private IProvider _provider;

        public ServiceManager(IProvider provider)
        {
            _provider = provider;
        }

        public void AddComputer(string computerName)
        {
            AddComputer(_provider.FindComputer(computerName));
        }

        public void RemoveComputer(string computerName)
        {
            _computers.Remove(computerName);
        }

        private void AddComputer(IComputer computer)
        {
            _computers.Add(computer.Name, computer);
        }

        public void StopServiceAt(string computerName, string serviceName)
        {
            if (!_computers.ContainsKey(computerName))
                return;

            _computers[computerName].StopService(serviceName);
        }

        public void RunServiceAt(string computerName, string serviceName)
        {
            if (!_computers.ContainsKey(computerName))
                return;

            _computers[computerName].RunService(serviceName);
        }

        public void RestartServiceAt(string computerName, string serviceName)
        {
            if (!_computers.ContainsKey(computerName))
                return;

            _computers[computerName].RestartService(serviceName);
        }
    }
}