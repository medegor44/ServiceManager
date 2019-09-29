using System.Collections.Generic;
using ServicesManager.Computers;
using ServicesManager.Providers;

namespace ServicesManager.MockupNetwork
{
    public class Provider : IProvider
    {
        private Dictionary<string, Computer> _computers = new Dictionary<string, Computer>();
        
        public Provider(IEnumerable<Computer> computers)
        {
            foreach (var comp in computers)
                _computers.Add(comp.Name, comp);
        }

        public IComputer FindComputer(string name)
        {
            if (!_computers.ContainsKey(name))
                return null;

            return _computers[name];
        }

        public IEnumerable<IComputer> EnumerateComputers()
        {
            return _computers.Values;
        }
    }
}
