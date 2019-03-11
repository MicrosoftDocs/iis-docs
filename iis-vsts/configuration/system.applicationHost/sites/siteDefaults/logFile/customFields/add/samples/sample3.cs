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
            ConfigurationElement logFileElement = siteDefaultsElement.GetChildElement("logFile");
            ConfigurationElement customFieldsElement = logFileElement.GetChildElement("customFields");
            ConfigurationElementCollection customFieldsCollection = customFieldsElement.GetCollection();
            
            ConfigurationElement addElement = customFieldsCollection.CreateElement("add");
            addElement["logFieldName"] = @"ContosoField";
            addElement["sourceName"] = @"ContosoSource";
            addElement["sourceType"] = @"ServerVariable";
            customFieldsCollection.Add(addElement);
            
            serverManager.CommitChanges();
        }
    }
}