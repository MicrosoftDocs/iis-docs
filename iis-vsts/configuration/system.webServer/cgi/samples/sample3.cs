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
         ConfigurationSection cgiSection = config.GetSection("system.webServer/cgi", "Default Web Site");

         cgiSection["createCGIWithNewConsole"] = true;
         cgiSection["createProcessAsUser"] = false;
         cgiSection["timeout"] = TimeSpan.Parse("00:20:00");

         serverManager.CommitChanges();
      }
   }
}