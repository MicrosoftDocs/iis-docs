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

         ConfigurationSection aspSection = config.GetSection("system.webServer/asp", "Contoso");
         aspSection["enableParentPaths"] = false;
         aspSection["bufferingOn"] = true;

         ConfigurationElement sessionElement = aspSection.GetChildElement("session");
         sessionElement["allowSessionState"] = true;

         serverManager.CommitChanges();
      }
   }
}