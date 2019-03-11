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
         ConfigurationElementCollection providersCollection = authenticationSection.GetCollection("providers");
         ConfigurationElement addElement = providersCollection.CreateElement("add");
         addElement["name"] = @"ContosoAuthenticationProvider";
         addElement["type"] = @"Contoso.Provider, System.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=426f62526f636b73";
         providersCollection.Add(addElement);
         authenticationSection["defaultProvider"] = "ContosoAuthenticationProvider";

         serverManager.CommitChanges();
      }
   }
}