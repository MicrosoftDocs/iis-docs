using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample {

    private static void Main() {
        
        using(ServerManager serverManager = new ServerManager()) { 
            Configuration config = serverManager.GetApplicationHostConfiguration();
            ConfigurationSection sitesSection = config.GetSection("system.applicationHost/sites");
            ConfigurationElement siteDefaultsElement = sitesSection.GetChildElement("siteDefaults");
            ConfigurationElement ftpServerElement = siteDefaultsElement.GetChildElement("ftpServer");
            ConfigurationElement securityElement = ftpServerElement.GetChildElement("security");
            ConfigurationElement customAuthorizationElement = securityElement.GetChildElement("customAuthorization");
            ConfigurationElement providerElement = customAuthorizationElement.GetChildElement("provider");
            providerElement["name"] = @"MyCustomProvider";
            providerElement["enabled"] = true;
            serverManager.CommitChanges();
        }
    }
}