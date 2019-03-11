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
         ConfigurationSection moduleProvidersSection = config.GetSection("moduleProviders");

         ConfigurationElementCollection moduleProvidersCollection = moduleProvidersSection.GetCollection();
         ConfigurationElement addElement = moduleProvidersCollection.CreateElement("add");
         addElement["name"] = @"ContosoProvider";
         addElement["type"] = @"Contoso.Provider, System.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=426f62526f636b73";
         moduleProvidersCollection.Add(addElement);

         serverManager.CommitChanges();
      }
   }
}