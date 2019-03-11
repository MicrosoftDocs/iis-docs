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

         ConfigurationSection httpRedirectSection = config.GetSection("system.webServer/httpRedirect");
         httpRedirectSection["enabled"] = true;
         httpRedirectSection["destination"] = @"http://www.contoso.com";
         httpRedirectSection["exactDestination"] = false;
         httpRedirectSection["httpResponseStatus"] = @"Found";

         serverManager.CommitChanges();
      }
   }
}