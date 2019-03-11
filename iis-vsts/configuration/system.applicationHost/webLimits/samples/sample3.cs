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
         ConfigurationSection webLimitsSection = config.GetSection("system.applicationHost/webLimits");

         webLimitsSection["connectionTimeout"] = TimeSpan.Parse("00:01:00");
         webLimitsSection["dynamicIdleThreshold"] = 150;
         webLimitsSection["headerWaitTimeout"] = TimeSpan.Parse("00:00:30");
         webLimitsSection["minBytesPerSecond"] = 500;

         serverManager.CommitChanges();
      }
   }
}