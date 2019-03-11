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
         ConfigurationSection sitesSection = config.GetSection("system.applicationHost/sites");
         ConfigurationElement siteDefaultsElement = sitesSection.GetChildElement("siteDefaults");

         ConfigurationElementCollection bindingsCollection = siteDefaultsElement.GetCollection("bindings");
         ConfigurationElement bindingElement = bindingsCollection.CreateElement("binding");
         bindingElement["protocol"] = @"http";
         bindingElement["bindingInformation"] = @"127.0.0.1:8080:";
         bindingsCollection.Add(bindingElement);

         serverManager.CommitChanges();
      }
   }
}