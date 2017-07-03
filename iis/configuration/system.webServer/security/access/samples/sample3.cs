using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample {
   private static void Main() {
      using(ServerManager serverManager = new ServerManager()) { 
         Configuration config = serverManager.GetApplicationHostConfiguration();
         ConfigurationSection accessSection = config.GetSection("system.webServer/security/access", "Contoso");
         accessSection["sslFlags"] = @"Ssl";
         serverManager.CommitChanges();
      }
   }
}