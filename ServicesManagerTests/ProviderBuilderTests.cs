using Xunit;
using System.Collections.Generic;
using System.Linq;
using ServicesManager.MockupNetwork;
using ServicesManager.Computers;

namespace ServicesManagerTests
{
    public class ProviderBuilderTests
    {
        [Fact]
        public void BuildProvider()
        {
            var comp1 = new ComputerBuilder()
                .SetName("1")
                .AddService(new Service("a", ServicesManager.Services.ServiceState.Running))
                .Build();

            var comp2 = new ComputerBuilder()
                .SetName("2")
                .AddService(new Service("b", ServicesManager.Services.ServiceState.Stopped))
                .Build();

            var provider = new ProviderBuilder().AddComputer(comp1).AddComputer(comp2).Build();

            var actual = provider.EnumerateComputers().ToHashSet();
            var expected = new HashSet<IComputer>()
            {
                comp1, 
                comp2
            };

            Assert.Equal(expected, actual);
        }
    }
}
