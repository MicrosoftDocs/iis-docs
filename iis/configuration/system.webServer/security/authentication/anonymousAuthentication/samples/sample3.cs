using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample { 
   private static void Main() { 
      using (ServerManager serverManager = new ServerManager()) {
         Configuration config = serverManager.GetApplicationHostConfiguration();
         ConfigurationSection anonymousAuthenticationSection = config.GetSection("system.webServer/security/authentication/anonymousAuthentication", "Contoso");
         anonymousAuthenticationSection["enabled"] = true;
         anonymousAuthenticationSection["userName"] = @"IUSR";
         anonymousAuthenticationSection["password"] = @"P@ssw0rd";
         serverManager.CommitChanges();
      } 
   } 
}