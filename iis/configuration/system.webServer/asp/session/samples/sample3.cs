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
         ConfigurationSection aspSection = config.GetSection("system.webServer/asp", "Default Web Site");

         ConfigurationElement sessionElement = aspSection.GetChildElement("session");
         sessionElement["allowSessionState"] = true;
         sessionElement["max"] = 1000;
         sessionElement["timeout"] = TimeSpan.Parse("00:10:00");

         serverManager.CommitChanges();
      }
   }
}