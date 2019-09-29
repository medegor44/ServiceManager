using ServicesManager.MockupNetwork;
using ServicesManager.Services;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ServicesManagerTests
{
    public class ComputerBuilderTests
    {
        [Fact]
        public void SetComputerNameWithoutServices()
        {
            var builder = new ComputerBuilder();
            builder.SetName("computer");

            var comp = builder.Build();

            var expected = "computer";
            var actual = comp.Name;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BuildComputerWithServices()
        {
            var builder = new ComputerBuilder();

            var comp = builder.SetName("a")
                .AddService(new Service("1", ServiceState.Running))
                .AddService(new Service("2", ServiceState.Stopped))
                .Build();

            var expected = new HashSet<IService>() 
            {
                new Service("1", ServiceState.Running),
                new Service("2", ServiceState.Stopped)
            };

            var actual = comp.EnumerateServices().ToHashSet();

            Assert.Equal(expected, actual);
        }
    }
}
