using System;
using System.IO;
using System.Runtime.InteropServices;
using AppHostAdminLibrary;
 
namespace ConfigurationExtensibility
{
    [ComVisible(true)]
    public class SimpleLoggingExtension : IAppHostPropertyExtension, IAppHostMethodExtension 
    {
        public void ProvideGetProperty(IappHostElement pElement, IappHostProperty pProperty)
        {
            switch(pProperty.Name)
            {
            case "logfileCount":
            string logDirectory = (string) pElement.Properties["logfileDirectory"].Value;
 
            if(Directory.Exists(logDirectory))
            pProperty.Value = Directory.GetFiles(logDirectory, "????????.log").Length;
            else 
           pProperty.Value = 0;
            break;
        }
        }
 
        public void ProvideMethod(IappHostMethod pMethod,
            IappHostMethodInstance pMethodInstance,
            IappHostElement pElement)
        {
            switch(pMethod.Name)
        {
            case "deleteLogs":
            string logDirectory = (string) pElement.Properties["logfileDirectory"].Value;
 
            if(Directory.Exists(logDirectory))
            {
            foreach(string logFile in Directory.GetFiles(logDirectory, "????????.log"))
            {
                File.Delete(logFile);
                }
            }
 
            break;
        }
        }
    }
}