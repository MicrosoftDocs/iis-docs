using System;
using System.IO;
using System.Runtime.InteropServices;
using AppHostAdminLibrary;

namespace ConfigurationExtensibility
{
    [ComVisible(true)]
    public class SimpleLoggingExtension : IAppHostPropertyExtension
    {
        public void ProvideGetProperty(IAppHostElement pElement, IAppHostProperty pProperty)
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
    }
}