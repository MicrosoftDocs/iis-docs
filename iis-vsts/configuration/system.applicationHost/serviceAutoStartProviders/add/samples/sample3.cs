using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample {
   private static void Main() {
      using(ServerManager serverManager = new ServerManager()) { 
         Configuration config = serverManager.GetApplicationHostConfiguration();
         ConfigurationSection serviceAutoStartProvidersSection = config.GetSection("system.applicationHost/serviceAutoStartProviders");
         ConfigurationElementCollection serviceAutoStartProvidersCollection = serviceAutoStartProvidersSection.GetCollection();

         ConfigurationElement addElement = serviceAutoStartProvidersCollection.CreateElement("add");
         addElement["name"] = @"MyAutostartProvider";
         addElement["type"] = @"MyAutostartProvider, MyAutostartProvider, version=1.0.0.0, Culture=neutral, PublicKeyToken=426f62526f636b73";
         serviceAutoStartProvidersCollection.Add(addElement);

         serverManager.CommitChanges();
      }
   }
}