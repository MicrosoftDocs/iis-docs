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
         ConfigurationSection httpLoggingSection = config.GetSection("system.webServer/httpLogging", "Contoso");
         httpLoggingSection["selectiveLogging"] = @"LogAll";
         httpLoggingSection["dontLog"] = true;
         serverManager.CommitChanges();
      }
   }
}