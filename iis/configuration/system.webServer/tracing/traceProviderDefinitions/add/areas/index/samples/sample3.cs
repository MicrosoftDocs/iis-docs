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
         ConfigurationSection traceProviderDefinitionsSection = config.GetSection("system.webServer/tracing/traceProviderDefinitions");
         ConfigurationElementCollection traceProviderDefinitionsCollection = traceProviderDefinitionsSection.GetCollection();

         ConfigurationElement addElement = traceProviderDefinitionsCollection.CreateElement("add");
         addElement["name"] = @"MyTraceProvider";
         addElement["guid"] = @"{00000000-0000-0000-0000-00000000000}";
         ConfigurationElementCollection areasCollection = addElement.GetCollection("areas");

         ConfigurationElement addElement1 = areasCollection.CreateElement("add");
         addElement1["name"] = @"ProviderAreaOne";
         addElement1["value"] = 0;
         areasCollection.Add(addElement1);

         ConfigurationElement addElement2 = areasCollection.CreateElement("add");
         addElement2["name"] = @"ProviderAreaTwo";
         addElement2["value"] = 1;
         areasCollection.Add(addElement2);

         traceProviderDefinitionsCollection.Add(addElement);
         serverManager.CommitChanges();
      }
   }
}