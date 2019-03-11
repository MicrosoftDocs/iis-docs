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
         ConfigurationElement siteDefaultsElement = sitesSection.GetChildElement("siteDefaults");

         ConfigurationElement limitsElement = siteDefaultsElement.GetChildElement("limits");
         limitsElement["connectionTimeout"] = TimeSpan.Parse("00:03:00");

         serverManager.CommitChanges();
      }
   }
}