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
         ConfigurationSection ipSecuritySection = config.GetSection("system.webServer/security/ipSecurity", "Default Web Site");
         ipSecuritySection["enableReverseDns"]=true;

         serverManager.CommitChanges();
      }
   }
}