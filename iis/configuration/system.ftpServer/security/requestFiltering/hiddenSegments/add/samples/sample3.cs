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
         ConfigurationElementCollection hiddenSegmentsCollection = requestFilteringSection.GetCollection("hiddenSegments");

         ConfigurationElement addElement = hiddenSegmentsCollection.CreateElement("add");
         addElement["segment"] = @"bin";
         hiddenSegmentsCollection.Add(addElement);

         ConfigurationElement addElement1 = hiddenSegmentsCollection.CreateElement("add");
         addElement1["segment"] = @"App_Code";
         hiddenSegmentsCollection.Add(addElement1);

         serverManager.CommitChanges();
      }
   }
}