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
         limitsElement["connectionTimeout"] = TimeSpan.Parse("00:02:00");

         ConfigurationElement logFileElement = siteDefaultsElement.GetChildElement("logFile");
         logFileElement["logFormat"] = @"W3C";
         logFileElement["directory"] = @"%SystemDrive%\inetpub\logs\LogFiles";
         logFileElement["enabled"] = true;

         ConfigurationElement traceFailedRequestsLoggingElement = siteDefaultsElement.GetChildElement("traceFailedRequestsLogging");
         traceFailedRequestsLoggingElement["enabled"] = true;
         traceFailedRequestsLoggingElement["directory"] = @"%SystemDrive%\inetpub\logs\FailedReqLogFiles";
         traceFailedRequestsLoggingElement["maxLogFiles"] = 20;

         ConfigurationElementCollection bindingsCollection = siteDefaultsElement.GetCollection("bindings");
         ConfigurationElement bindingElement = bindingsCollection.CreateElement("binding");
         bindingElement["protocol"] = @"http";
         bindingElement["bindingInformation"] = @"127.0.0.1:8080:";
         bindingsCollection.Add(bindingElement);

         ConfigurationElement ftpServerElement = siteDefaultsElement.GetChildElement("ftpServer");
         ftpServerElement["serverAutoStart"] = true;

         serverManager.CommitChanges();
      }
   }
}