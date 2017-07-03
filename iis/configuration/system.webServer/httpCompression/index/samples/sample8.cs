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
         ConfigurationSection httpCompressionSection = config.GetSection("system.webServer/httpCompression");
         ConfigurationElementCollection staticTypesCollection = httpCompressionSection.GetCollection("staticTypes");

         ConfigurationElement addElement = staticTypesCollection.CreateElement("add");
         addElement["mimeType"] = @"application/msword";
         addElement["enabled"] = true;
         staticTypesCollection.Add(addElement);

         ConfigurationElement addElement1 = staticTypesCollection.CreateElement("add");
         addElement1["mimeType"] = @"application/vnd.ms-powerpoint";
         addElement1["enabled"] = true;
         staticTypesCollection.Add(addElement1);

         ConfigurationElement addElement2 = staticTypesCollection.CreateElement("add");
         addElement2["mimeType"] = @"application/vnd.ms-excel";
         addElement2["enabled"] = true;
         staticTypesCollection.Add(addElement2);

         serverManager.CommitChanges();
      }
   }
}