using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample
{
    private static void Main()
    {
        using(ServerManager serverManager = new ServerManager())
        { 
            Configuration config = serverManager.GetApplicationHostConfiguration();
            ConfigurationSection sitesSection = config.GetSection("system.applicationHost/sites");
            ConfigurationElement siteDefaultsElement = sitesSection.GetChildElement("siteDefaults");
            
            ConfigurationElement hstsElement = siteDefaultsElement.GetChildElement("hsts");
            hstsElement["enabled"] = true;
            hstsElement["max-age"] = 31536000;
            hstsElement["includeSubDomains"] = true;
            hstsElement["redirectHttpToHttps"] = true;
            
            serverManager.CommitChanges();
        }
    }
}