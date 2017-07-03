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
         ConfigurationSection globalModulesSection = config.GetSection("system.webServer/globalModules");
         ConfigurationElementCollection globalModulesCollection = globalModulesSection.GetCollection();
         ConfigurationElement addElement = globalModulesCollection.CreateElement("add");
         addElement["name"] = @"ImageCopyrightModule";
         addElement["image"] = @"%windir%\system32\inetsrv\imageCopyrightModule.dll";
         globalModulesCollection.Add(addElement);
         serverManager.CommitChanges();
      }
   }
}