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

         ConfigurationElement logFileElement = siteDefaultsElement.GetChildElement("logFile");
         logFileElement["logFormat"] = @"W3C";
         logFileElement["directory"] = @"%SystemDrive%\inetpub\logs\LogFiles";
         logFileElement["enabled"] = true;

         serverManager.CommitChanges();
      }
   }
}