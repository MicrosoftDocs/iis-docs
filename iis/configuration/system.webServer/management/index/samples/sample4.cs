using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample
{
   private static void Main()
   {
      using (ServerManager serverManager = new ServerManager())
      {
         Configuration config = serverManager.GetAdministrationConfiguration();

         ConfigurationSection authenticationSection = config.GetSection("system.webServer/management/authentication");
         ConfigurationElementCollection credentialsCollection = authenticationSection.GetCollection("credentials");
         ConfigurationElement addElement = credentialsCollection.CreateElement("add");
         addElement["name"] = @"ContosoUser";
         addElement["password"] = @"P@ssw0rd";
         addElement["enabled"] = true;
         credentialsCollection.Add(addElement);

         serverManager.CommitChanges();
      }
   }
}