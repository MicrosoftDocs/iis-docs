using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample
{
   private static void Main()
   {
      using (ServerManager serverManager = new ServerManager())
      {
         Configuration config = serverManager.GetWebConfiguration("Contoso");
         ConfigurationSection modulesSection = config.GetSection("system.webServer/modules");
         ConfigurationElementCollection modulesCollection = modulesSection.GetCollection();

         ConfigurationElement addElement = modulesCollection.CreateElement("add");
         addElement["name"] = @"CartHeader";
         addElement["type"] = @"Contoso.ShoppingCart.Header";
         addElement["preCondition"] = @"managedHandler";
         modulesCollection.Add(addElement);

         serverManager.CommitChanges();
      }
   }
}