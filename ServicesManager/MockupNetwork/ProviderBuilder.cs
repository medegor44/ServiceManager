using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesManager.MockupNetwork
{
    public class ProviderBuilder
    {
        private List<Computer> _computers = new List<Computer>();

        public ProviderBuilder AddComputer(Computer computer)
        {
            _computers.Add(computer);
            return this;
        }

        public Provider Build()
        {
            return new Provider(_computers);
        }
    }
}
