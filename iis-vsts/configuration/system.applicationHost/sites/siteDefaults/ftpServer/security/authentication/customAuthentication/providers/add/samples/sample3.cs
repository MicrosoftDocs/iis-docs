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
         ConfigurationElement customAuthenticationElement = authenticationElement.GetChildElement("customAuthentication");
         ConfigurationElementCollection providersCollection = customAuthenticationElement.GetCollection("providers");
         ConfigurationElement addElement1 = providersCollection.CreateElement("add");
            addElement1["name"] = @"FtpCustomAuthenticationModule";
            addElement1["enabled"] = true;
            providersCollection.Add(addElement1);

         serverManager.CommitChanges();
      }
   }
}