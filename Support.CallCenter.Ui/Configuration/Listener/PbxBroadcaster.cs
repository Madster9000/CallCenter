using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Hubs;
using Support.CallCenter.Pbx.EventArguments;
using Support.CallCenter.Pbx.Listeners.Interfaces;
using Support.CallCenter.Pbx.PbxEventCache;
using Support.CallCenter.Pbx.Services.Interfaces;
using Support.CallCenter.Ui.Configuration.NLog;
using Support.Crm.Repository.Interfaces;

namespace Support.CallCenter.Ui.Configuration.Listener
{
    public class PbxBroadcaster
    {
        private readonly IHubConnectionContext<dynamic> mClients;
        private readonly IPbxListener mPbxListener;
        private readonly IRepository<PbxEventCache> mPbxEventCachesRepository;

        

        public PbxBroadcaster
            (
            IHubConnectionContext<dynamic> clients, 
            IPbxListener pbxListener, 
            IRepository<PbxEventCache> pbxEventCachesRepository
            )
        {
            mClients = clients;
            mPbxListener = pbxListener;
            mPbxEventCachesRepository = pbxEventCachesRepository;
        }

        public void StartListen()
        {
            NLogContaner.Instance.Debug("Server started");
            Task.Factory.StartNew(() =>
            {
                mPbxListener.PbxMessageRecived += ProcessAsteriskMessages;
                mPbxListener.PbxConnectionLost += SendErrorMessageToClients;
                mPbxListener.FullMessageRecived += SendLogMessage;
                mPbxListener.Listen();
            });
        }

        private void ProcessAsteriskMessages(object sender, PbxMessagesEventArgs e)
        {
            var logMessage = "\r\n Parsed messages:" +
                             String
                                 .Join
                                 (
                                     "\r\n\r\n",
                                     e.Messages
                                         .Select
                                         (
                                             r => String.Join("\r\n", r.Select(x => x.Key + " " + x.Value))
                                         )
                                 )
                             + "\r\n End of parsed messages."
                ;

            NLogContaner.Instance.Trace(logMessage);

            foreach (var pbxEvent in e.Messages)
            {
                var eventCache = new PbxEventCache
                {
                    Event = pbxEvent,
                    TimeStamp = DateTime.Now
                };
                mPbxEventCachesRepository.Create(eventCache);
            }

            mClients.All.broadcastMessage(e.Messages);

        }

        private void SendErrorMessageToClients(object sender, PbxErrorEventArgs e)
        {
            NLogContaner.Instance.Error(e.ErrorMessage);
            Task.Factory.StartNew(() =>
            {
                mPbxListener.Listen();
            });
        }

        private void SendLogMessage(object sender, PbxRawMessageEventArgs e)
        {
            NLogContaner.Instance.Trace(e.Message);
        }
    }
}