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
         ConfigurationSection sitesSection = config.GetSection("system.applicationHost/sites");

         ConfigurationElement applicationDefaultsElement = sitesSection.GetChildElement("applicationDefaults");
         applicationDefaultsElement["applicationPool"] = @"DefaultAppPool";

         serverManager.CommitChanges();
     }
   }
}