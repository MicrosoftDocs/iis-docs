using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample {

   private static void Main() {

      using(ServerManager serverManager = new ServerManager()) { 
         Configuration config = serverManager.GetApplicationHostConfiguration();

         ConfigurationSection digestAuthenticationSection = config.GetSection("system.webServer/security/authentication/digestAuthentication", "Contoso");
         digestAuthenticationSection["enabled"] = true;

        serverManager.CommitChanges();
      }
   }
}