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
         ConfigurationSection requestFilteringSection = config.GetSection("system.ftpServer/security/requestFiltering", "Default Web Site");

         ConfigurationElement requestLimitsElement = requestFilteringSection.GetChildElement("requestLimits");
         requestLimitsElement["maxAllowedContentLength"] = 1000000;
         requestLimitsElement["maxUrl"] = 1024;

         serverManager.CommitChanges();
      }
   }
}