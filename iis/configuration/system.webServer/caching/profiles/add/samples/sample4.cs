using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample {
   private static void Main() {
      using(ServerManager serverManager = new ServerManager()) { 
         Configuration config = serverManager.GetApplicationHostConfiguration();
         ConfigurationSection cachingSection = config.GetSection("system.webServer/caching");
         ConfigurationElementCollection profilesCollection = cachingSection.GetCollection("profiles");

         ConfigurationElement addElement = profilesCollection.CreateElement("add");
         addElement["extension"] = @"asp";
         addElement["policy"] = @"CacheUntilChange";
         addElement["kernelCachePolicy"] = @"CacheUntilChange";
         profilesCollection.AddAt(0, addElement);

         serverManager.CommitChanges();
      }
   }
}