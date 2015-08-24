using System;
using System.Net;
using Support.CallCenter.Pbx.Configuration;
using Support.CallCenter.Pbx.Services.Interfaces;

namespace Support.CallCenter.Pbx.Services.Implementations
{
    public class AsteriskConfigurationService: IPbxConfigurationService
    {
        public string GetLoginCommand(PbxConfiguration pbxConfiguration)
        {
            return
                String.Format
                    (
                        "Action: Login\r\nUsername: {0}\r\nSecret: {1}\r\nActionID: 1\r\n\r\n",
                        pbxConfiguration.UserName,
                        pbxConfiguration.Password
                    );
        }

        public PbxConfiguration GetPbxConfiguration()
        {
            return
                new PbxConfiguration
                {
                    IpAddress = IPAddress.Parse("192.168.0.1"),
                    Port = 8080,
                    UserName = "login",
                    Password = "pass"
                };
        }
    }
}