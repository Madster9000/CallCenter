using System;
using Support.CallCenter.Pbx.EventArguments;

namespace Support.CallCenter.Pbx.Listeners.Interfaces
{
    public interface IPbxListener
    {
        void Listen();
        event EventHandler<PbxRawMessageEventArgs> FullMessageRecived;
        event EventHandler<PbxMessagesEventArgs> PbxMessageRecived;
        event EventHandler<PbxErrorEventArgs> PbxConnectionLost;
    }
}