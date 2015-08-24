using System;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using Support.CallCenter.Pbx.Adapters.Interfaces;

namespace Support.CallCenter.Pbx.Adapters.Implementations
{
    public class StubSocketAdapter: ISocketAdapter
    {
        //
        private int mCallId = 0;

        private string MissedNewChannelEvent
        {
            get { return "Event: Newchannel\r\nCallerIDNum: 89506710105" + mCallId + "\r\nUniqueid: "+mCallId+"\r\n\r\n"; }
        }
        private string EndedNewChannelEvent
        {
            get { return "Event: Newchannel\r\nCallerIDNum: 89501111111" + mCallId + 1 + "\r\nUniqueid: " + mCallId + 1 + "\r\n\r\n"; }
        }

        private string MissedJoinEvent
        {
            get { return "Event: Join\r\nQueue: 908\r\nUniqueid: " + mCallId + "\r\n\r\n"; }
        }

        private string EndedJoinEvent
        {
            get { return "Event: Join\r\nQueue: 908\r\nUniqueid: " + mCallId + 1 + "\r\n\r\n"; }
        }

        private string BridgeEvent
        {
            get { return "Event: Bridge\r\nCallerID2: 7896\r\nUniqueid1: " + mCallId + 1 + "\r\n\r\n"; }
        }

        private string MissedHangupEvent
        {
            get { return "Event: Hangup\r\nCause: 16\r\nUniqueid: " + mCallId + "\r\n\r\n"; }
        }

        private string EndedHangupEvent
        {
            get { return "Event: Hangup\r\nCause: 16\r\nUniqueid: " + mCallId + 1 + "\r\n\r\n"; }
        }

        private const string cJunkMessage = "test: 1\r\n\r\n";
        private const string cJunkMessage2 = "Event: Junk\r\n\r\n";

        public int Receive(byte[] buffer)
        {
            var testMessage = new StringBuilder();
            testMessage.Append(MissedNewChannelEvent);
            testMessage.Append(MissedJoinEvent);
            testMessage.Append(MissedHangupEvent);

            testMessage.Append(EndedNewChannelEvent);
            testMessage.Append(EndedJoinEvent);
            testMessage.Append(BridgeEvent);
            testMessage.Append(EndedHangupEvent);

            testMessage.Append(cJunkMessage);
            testMessage.Append(cJunkMessage2);

            mCallId++;

            Thread.Sleep(5000);
            
            var msgArray = Encoding.ASCII.GetBytes(testMessage.ToString());
            msgArray.CopyTo(buffer,0);
            return buffer.Count();
        }

        public int Send(byte[] data)
        {
            return 1;
        }

        public void Disconnect()
        {
        }

        public void Connect(IPAddress address, int port)
        {
        }

        public void Dispose()
        {
            
        }
    }
}