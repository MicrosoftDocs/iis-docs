using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample
{
   private static void Main()
   {
      using (ServerManager serverManager = new ServerManager())
      {
         Configuration config = serverManager.GetApplicationHostConfiguration();
         ConfigurationSection authoringSection = config.GetSection("system.webServer/webdav/authoring", "Default Web Site");

         ConfigurationElement propertiesElement = authoringSection.GetChildElement("properties");
         propertiesElement["allowAnonymousPropfind"] = false;
         propertiesElement["allowInfinitePropfindDepth"] = false;
         propertiesElement["allowCustomProperties"] = true;

         ConfigurationElementCollection propertiesCollection = propertiesElement.GetCollection();

         ConfigurationElement addElement = propertiesCollection.CreateElement("add");
         addElement["xmlNamespace"] = @"*";
         addElement["propertyStore"] = @"webdav_simple_prop";
         propertiesCollection.Add(addElement);

         serverManager.CommitChanges();
      }
   }
}