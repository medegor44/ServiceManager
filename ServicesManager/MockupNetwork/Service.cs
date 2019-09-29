using ServicesManager.Services;

namespace ServicesManager.MockupNetwork
{
    public class Service : IService
    {
        public string Name { get; }
        public ServiceState State { get; private set; }

        public Service(string name, ServiceState state)
        {
            Name = name;
            State = state;
        }

        public void Stop()
        {
            if (State == ServiceState.Running)
                State = ServiceState.Stopped;
        }

        public void Run()
        {
            if (State == ServiceState.Stopped)
                State = ServiceState.Running;
        }

        public void Restart()
        {
            if (State == ServiceState.Running)
                Stop();
            Run();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Service))
                return false;

            var s = (Service)obj;

            return s.Name == Name && s.State == State;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode()*10 + (int)State;
        }
    }
}