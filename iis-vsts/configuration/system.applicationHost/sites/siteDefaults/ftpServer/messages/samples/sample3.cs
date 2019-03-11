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

         ConfigurationElement messagesElement = ftpServerElement.GetChildElement("messages");
            messagesElement["bannerMessage"] = @"Welcome!";
            messagesElement["allowLocalDetailedErrors"] = true;

         serverManager.CommitChanges();
      }
   }
}