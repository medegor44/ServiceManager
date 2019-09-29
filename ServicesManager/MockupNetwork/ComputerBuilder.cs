using System.Collections.Generic;

namespace ServicesManager.MockupNetwork
{
    public class ComputerBuilder
    {
        private string _computerName;
        private List<Service> _services = new List<Service>();

        public ComputerBuilder SetName(string name)
        {
            _computerName = name;
            return this;
        }

        public ComputerBuilder AddService(Service service)
        {
            _services.Add(service);
            return this;
        }

        public Computer Build()
        {
            return new Computer(_computerName, _services);
        }
    }
}
