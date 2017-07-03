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
         ConfigurationSection httpTracingSection = config.GetSection("system.webServer/httpTracing", "Contoso");
         ConfigurationElementCollection traceUrlsCollection = httpTracingSection.GetCollection("traceUrls");

         ConfigurationElement addElement = traceUrlsCollection.CreateElement("add");
         addElement["value"] = @"/iisstart.htm";
         traceUrlsCollection.Add(addElement);

         serverManager.CommitChanges();
      }
   }
}