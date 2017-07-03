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

         ConfigurationElement traceFailedRequestsLoggingElement = siteDefaultsElement.GetChildElement("traceFailedRequestsLogging");
         traceFailedRequestsLoggingElement["enabled"] = true;
         traceFailedRequestsLoggingElement["directory"] = @"%SystemDrive%\inetpub\logs\FailedReqLogFiles";
         traceFailedRequestsLoggingElement["maxLogFiles"] = 20;

         serverManager.CommitChanges();
      }
   }
}