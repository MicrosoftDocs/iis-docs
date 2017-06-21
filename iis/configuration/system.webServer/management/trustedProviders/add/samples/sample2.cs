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

         ConfigurationSection trustedProvidersSection = config.GetSection("system.webServer/management/trustedProviders");
         ConfigurationElementCollection trustedProvidersCollection = trustedProvidersSection.GetCollection();
         ConfigurationElement addElement = trustedProvidersCollection.CreateElement("add");
         addElement["type"] = @"Contoso.Provider, System.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=426f62526f636b73";
         trustedProvidersCollection.Add(addElement);

         serverManager.CommitChanges();
      }
   }
}