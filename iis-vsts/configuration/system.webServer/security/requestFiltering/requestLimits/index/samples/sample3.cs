using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample
{
   private static void Main()
   {
      using (ServerManager serverManager = new ServerManager())
      {
         Configuration config = serverManager.GetWebConfiguration("Default Web Site");
         ConfigurationSection requestFilteringSection = config.GetSection("system.webServer/security/requestFiltering");
         ConfigurationElement requestLimitsElement = requestFilteringSection.GetChildElement("requestLimits");
         ConfigurationElementCollection headerLimitsCollection = requestLimitsElement.GetCollection("headerLimits");

         ConfigurationElement addElement = headerLimitsCollection.CreateElement("add");
         addElement["header"] = @"Content-type";
         addElement["sizeLimit"] = 100;
         headerLimitsCollection.Add(addElement);

         serverManager.CommitChanges();
      }
   }
}