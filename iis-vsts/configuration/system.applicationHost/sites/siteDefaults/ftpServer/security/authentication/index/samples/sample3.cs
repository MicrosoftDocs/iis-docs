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

         ConfigurationElement securityElement = ftpServerElement.GetChildElement("security");
         ConfigurationElement authenticationElement = securityElement.GetChildElement("authentication");
         ConfigurationElement anonymousAuthenticationElement = authenticationElement.GetChildElement("anonymousAuthentication");
            anonymousAuthenticationElement["enabled"] = false;
         ConfigurationElement basicAuthenticationElement = authenticationElement.GetChildElement("basicAuthentication");
            basicAuthenticationElement["enabled"] = true;
 
           serverManager.CommitChanges();
      }
   }
}