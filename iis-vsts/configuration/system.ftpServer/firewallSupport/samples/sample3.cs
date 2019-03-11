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

         ConfigurationSection logSection = config.GetSection("system.ftpServer/log");
         logSection["centralLogFileMode"] = @"Central";

         ConfigurationElement centralLogFileElement = logSection.GetChildElement("centralLogFile");
         centralLogFileElement["enabled"] = true;

         serverManager.CommitChanges();
      }
   }
}