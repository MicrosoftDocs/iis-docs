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
         ConfigurationSection modulesSection = config.GetSection("modules");

         ConfigurationElementCollection modulesCollection = modulesSection.GetCollection();
         ConfigurationElement addElement = modulesCollection.CreateElement("add");
         addElement["name"] = @"ContosoProvider";
         modulesCollection.Add(addElement);

         serverManager.CommitChanges();
      }
   }
}