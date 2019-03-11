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

         ConfigurationSection configHistorySection = config.GetSection("system.applicationHost/configHistory");
         configHistorySection["enabled"] = true;
         configHistorySection["path"] = @"%SystemDrive%\inetpub\history";
         configHistorySection["maxHistories"] = 50;
         configHistorySection["period"] = TimeSpan.Parse("00:05:00");

         serverManager.CommitChanges();
      }
   }
}