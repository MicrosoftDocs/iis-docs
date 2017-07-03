using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample
{
   private static void Main()
   {
      using (ServerManager serverManager = new ServerManager())
      {
         Configuration config = serverManager.GetWebConfiguration("Contoso");
         ConfigurationSection traceFailedRequestsSection = config.GetSection("system.webServer/tracing/traceFailedRequests");
         ConfigurationElementCollection traceFailedRequestsCollection = traceFailedRequestsSection.GetCollection();

         ConfigurationElement addElement = traceFailedRequestsCollection.CreateElement("add");
         addElement["path"] = @"*.aspx";

         ConfigurationElementCollection traceAreasCollection = addElement.GetCollection("traceAreas");
         ConfigurationElement addElement1 = traceAreasCollection.CreateElement("add");
         addElement1["provider"] = @"ASPNET";
         addElement1["areas"] = @"Infrastructure,Module,Page,AppServices";
         addElement1["verbosity"] = @"Verbose";
         traceAreasCollection.Add(addElement1);

         ConfigurationElement failureDefinitionsElement = addElement.GetChildElement("failureDefinitions");
         failureDefinitionsElement["statusCodes"] = @"500";
         traceFailedRequestsCollection.Add(addElement);

         serverManager.CommitChanges();
      }
   }
}