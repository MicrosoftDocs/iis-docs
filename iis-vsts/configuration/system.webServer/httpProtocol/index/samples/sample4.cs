using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample
{
   private static void Main()
   {
      using (ServerManager serverManager = new ServerManager())
      {
         Configuration config = serverManager.GetWebConfiguration("Default Web Site");

         ConfigurationSection httpProtocolSection = config.GetSection("system.webServer/httpProtocol");
         httpProtocolSection["allowKeepAlive"] = true;

         serverManager.CommitChanges();
      }
   }
}