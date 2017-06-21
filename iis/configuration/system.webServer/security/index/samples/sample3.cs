using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample {

   private static void Main() {

      using(ServerManager serverManager = new ServerManager()) { 
         Configuration config = serverManager.GetApplicationHostConfiguration();

         ConfigurationSection anonymousAuthenticationSection = config.GetSection("system.webServer/security/authentication/anonymousAuthentication", "Contoso");
         anonymousAuthenticationSection["enabled"] = false;

         ConfigurationSection basicAuthenticationSection = config.GetSection("system.webServer/security/authentication/basicAuthentication", "Contoso");
         basicAuthenticationSection["enabled"] = true;

         ConfigurationSection windowsAuthenticationSection = config.GetSection("system.webServer/security/authentication/windowsAuthentication", "Contoso");
         windowsAuthenticationSection["enabled"] = true;

         serverManager.CommitChanges();
      }
   }
}