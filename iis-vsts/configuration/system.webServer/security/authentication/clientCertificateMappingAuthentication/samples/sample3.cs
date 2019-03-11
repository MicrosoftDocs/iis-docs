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

         ConfigurationSection clientCertificateMappingAuthenticationSection = config.GetSection("system.webServer/security/authentication/clientCertificateMappingAuthentication", "Default Web Site");
         clientCertificateMappingAuthenticationSection["enabled"] = true;

         ConfigurationSection accessSection = config.GetSection("system.webServer/security/access", "Default Web Site");
         accessSection["sslFlags"] = @"Ssl, SslNegotiateCert";

         serverManager.CommitChanges();
      }
   }
}