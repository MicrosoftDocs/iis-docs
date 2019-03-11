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
         ConfigurationElementCollection dynamicTypesCollection = httpCompressionSection.GetCollection("dynamicTypes");

         ConfigurationElement addElement = dynamicTypesCollection.CreateElement("add");
         addElement["mimeType"] = @"application/msword";
         addElement["enabled"] = true;
         dynamicTypesCollection.Add(addElement);

         ConfigurationElement addElement1 = dynamicTypesCollection.CreateElement("add");
         addElement1["mimeType"] = @"application/vnd.ms-powerpoint";
         addElement1["enabled"] = true;
         dynamicTypesCollection.Add(addElement1);

         ConfigurationElement addElement2 = dynamicTypesCollection.CreateElement("add");
         addElement2["mimeType"] = @"application/vnd.ms-excel";
         addElement2["enabled"] = true;
         dynamicTypesCollection.Add(addElement2);

         serverManager.CommitChanges();
      }
   }
}