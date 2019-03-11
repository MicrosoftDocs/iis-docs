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

         ConfigurationElement hiddenSegmentsElement = requestFilteringSection.GetChildElement("hiddenSegments");
         hiddenSegmentsElement["applyToWebDAV"] = false;
         ConfigurationElementCollection hiddenSegmentsCollection = hiddenSegmentsElement.GetCollection();

         ConfigurationElement addElement = hiddenSegmentsCollection.CreateElement("add");
         addElement["segment"] = @"_private";
         hiddenSegmentsCollection.Add(addElement);

         serverManager.CommitChanges();
      }
   }
}