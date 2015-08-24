using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Support.CallCenter.Pbx.EventArguments;
using Support.CallCenter.Pbx.Listeners.Implementations;
using Support.CallCenter.Pbx.Listeners.Interfaces;
using Support.CallCenter.Pbx.Services.Interfaces;
using Support.CallCenter.Ui.Configuration.Listener;
using Support.CallCenter.Ui.Contracts;

namespace Support.CallCenter.Ui.Hubs
{
    public class AsteriskHub : Hub
    {
        public void CallWasCalledBack(RemovePbxEventRequest request)
        {
            Clients.All.broadcastCalledBackCall(request.PbxEventId);
        }
    }
}