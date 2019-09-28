using System.Collections.Generic;
using ServicesManager.Computers;

namespace ServicesManager.Providers
{
    public interface IProvider
    {
        IComputer FindComputer(string name);
        IEnumerable<IComputer> GetComputers();
    }
}