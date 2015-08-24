using System;
using System.Net;

namespace Support.CallCenter.Pbx.Adapters.Interfaces
{
    /// <summary>
    /// Обёртка для класса Socket
    /// </summary>
    public interface ISocketAdapter: IDisposable
    {
        int Receive(byte[] buffer);

        int Send(byte[] data);

        void Disconnect();

        void Connect(IPAddress address, int port);
    }
}