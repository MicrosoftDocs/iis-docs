using System;
using Microsoft.Web.Administration;
using System.Configuration;

namespace testingEncryption
{   
    public class createProvider   
    {
        public static void Main(string[] args)
        {
            String keyContainerName = args[0];
            String description = args[1];
            String providerName = args[2];
            System.Configuration.Configuration machineConfig =
            System.Configuration.ConfigurationManager.OpenMachineConfiguration();
            System.Configuration.ProviderSettings settings =
                new System.Configuration.ProviderSettings(providerName,
                "System.Configuration.RsaProtectedConfigurationProvider,
                System.Configuration,
                Version=2.0.0.0, Culture=neutral,
                PublicKeyToken=b03f5f7f11d50a3a");
            settings.Parameters["description"] = description;
            settings.Parameters["keyContainerName"] = keyContainerName;
            settings.Parameters["cspProviderName"] = String.Empty;
            settings.Parameters["useMachineContainer"] = "true";
            settings.Parameters["useOAEP"] = "false";
            settings.Parameters["name"] = providerName;
            ProtectedConfigurationSection pcSection =
                (System.Configuration.ProtectedConfigurationSection)machineConfig.GetSection ("configProtectedData");
            pcSection.Providers.Add(settings);
            machineConfig.Save();
        }
    }
}