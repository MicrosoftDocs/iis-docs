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
         ConfigurationElement ftpServerElement = siteDefaultsElement.GetChildElement("ftpServer");

         ConfigurationElement firewallSupportElement = ftpServerElement.GetChildElement("firewallSupport");
            firewallSupportElement["externalIp4Address"] = @"169.254.10.10";

         serverManager.CommitChanges();
      }
   }
}