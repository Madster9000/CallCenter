using Support.CallCenter.Pbx.Configuration;

namespace Support.CallCenter.Pbx.Services.Interfaces
{
    public interface IPbxConfigurationService
    {
        string GetLoginCommand(PbxConfiguration pbxConfiguration);
        PbxConfiguration GetPbxConfiguration();
    }
}