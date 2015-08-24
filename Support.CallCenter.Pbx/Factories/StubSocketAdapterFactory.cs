using Support.CallCenter.Pbx.Adapters.Implementations;
using Support.CallCenter.Pbx.Adapters.Interfaces;

namespace Support.CallCenter.Pbx.Factories
{
    public class StubSocketAdapterFactory: ISocketAdapterFactory
    {
        public ISocketAdapter CreateSocketAdapter()
        {
            return new StubSocketAdapter();
        }
    }
}