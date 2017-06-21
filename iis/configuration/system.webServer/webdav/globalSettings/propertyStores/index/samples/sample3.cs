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
         ConfigurationSection globalSettingsSection = config.GetSection("system.webServer/webdav/globalSettings");

         ConfigurationElementCollection propertyStoresCollection = globalSettingsSection.GetCollection("propertyStores");

         ConfigurationElement addElement = propertyStoresCollection.CreateElement("add");
         addElement["name"] = @"webdav_simple_prop";
         addElement["image"] = @"%windir%\system32\inetsrv\webdav_simple_prop.dll";
         propertyStoresCollection.Add(addElement);

         ConfigurationElementCollection lockStoresCollection = globalSettingsSection.GetCollection("lockStores");

         ConfigurationElement addElement1 = lockStoresCollection.CreateElement("add");
         addElement1["name"] = @"webdav_simple_lock";
         addElement1["image"] = @"%windir%\system32\inetsrv\webdav_simple_lock.dll";
         lockStoresCollection.Add(addElement1);

         serverManager.CommitChanges();
      }
   }
}