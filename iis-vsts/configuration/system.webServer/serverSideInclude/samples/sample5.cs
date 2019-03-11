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

         ConfigurationSection serverSideIncludeSection = config.GetSection("system.webServer/serverSideInclude", "Default Web Site");
         serverSideIncludeSection["ssiExecDisable"] = true;

         serverManager.CommitChanges();
      }
   }
}