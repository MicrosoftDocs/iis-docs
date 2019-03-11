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

         ConfigurationSection serverRuntimeSection = config.GetSection("system.webServer/serverRuntime", "Default Web Site");
         serverRuntimeSection["enabled"] = true;
         serverRuntimeSection["frequentHitThreshold"] = 5;
         serverRuntimeSection["frequentHitTimePeriod"] = TimeSpan.Parse("00:00:20");

         serverManager.CommitChanges();
      }
   }
}