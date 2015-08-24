using System.Net;

namespace Support.CallCenter.Pbx.Configuration
{
    public class PbxConfiguration
    {
        public IPAddress IpAddress { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}