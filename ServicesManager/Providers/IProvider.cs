using System.Collections.Generic;
using ServicesManager.Computers;

namespace ServicesManager.Providers
{
    public interface IProvider
    {
        IComputer GetComputer(string name);
        IEnumerable<IComputer> EnumerateComputers();
    }
}