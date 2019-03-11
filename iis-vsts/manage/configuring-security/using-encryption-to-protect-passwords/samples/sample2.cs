using System;
using Microsoft.Web.Administration;
using System.Configuration;
namespace testingEncryption 
{
    public class setProvider
    {
        public static void Main(string[] args)
        {
            String provider = args[0];  // example: DataProtectionConfigurationProvider
            System.Configuration.Configuration machineConfig =
                System.Configuration.ConfigurationManager.OpenMachineConfiguration();
            ProtectedConfigurationSection pcSection =
                (System.Configuration.ProtectedConfigurationSection)machineConfig.GetSection("configProtectedData");
            string oldEncryptionProviderName = pcSection.DefaultProvider;
            Console.WriteLine("The default provider is currently: " + oldEncryptionProviderName);
            Console.WriteLine("Changing the default provider to: " + provider);
            pcSection.DefaultProvider = provider;
            machineConfig.Save();
        }
    }
}