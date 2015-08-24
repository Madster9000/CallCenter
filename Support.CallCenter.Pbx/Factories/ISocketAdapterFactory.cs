using Support.CallCenter.Pbx.Adapters.Interfaces;

namespace Support.CallCenter.Pbx.Factories
{
    public interface ISocketAdapterFactory
    {
        ISocketAdapter CreateSocketAdapter();
    }
}