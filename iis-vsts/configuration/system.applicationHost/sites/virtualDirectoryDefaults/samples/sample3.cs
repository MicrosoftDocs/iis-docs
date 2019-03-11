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

         ConfigurationElement virtualDirectoryDefaultsElement = sitesSection.GetChildElement("virtualDirectoryDefaults");
         virtualDirectoryDefaultsElement["logonMethod"] = @"Network";

         serverManager.CommitChanges();
      }
   }
}