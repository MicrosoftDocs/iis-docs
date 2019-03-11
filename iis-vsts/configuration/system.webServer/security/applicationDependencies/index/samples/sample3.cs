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
         ConfigurationSection applicationDependenciesSection = config.GetSection("system.webServer/security/applicationDependencies", "Default Web Site");

         ConfigurationElementCollection applicationDependenciesCollection = applicationDependenciesSection.GetCollection();
         ConfigurationElement applicationElement = applicationDependenciesCollection.CreateElement("application");
         applicationElement["name"] = @"My Custom Application";
         applicationElement["groupId"] = @"MyCustomGroup";

         ConfigurationElementCollection applicationCollection = applicationElement.GetCollection();
         ConfigurationElement addElement = applicationCollection.CreateElement("add");
         addElement["groupId"] = @"ASP";
         applicationCollection.Add(addElement);
         applicationDependenciesCollection.Add(applicationElement);

         serverManager.CommitChanges();
      }
   }
}