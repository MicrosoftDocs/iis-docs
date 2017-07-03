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
         ConfigurationSection aspSection = config.GetSection("system.webServer/asp");

         ConfigurationElement limitsElement = aspSection.GetChildElement("limits");
         limitsElement["scriptTimeout"] = TimeSpan.Parse("00:02:00");
         limitsElement["queueConnectionTestTime"] = TimeSpan.Parse("00:00:05");
         limitsElement["requestQueueMax"] = 1000;

         serverManager.CommitChanges();
      }
   }
}