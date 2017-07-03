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

         ConfigurationSection logSection = config.GetSection("system.applicationHost/log");
         logSection["centralLogFileMode"] = @"CentralW3C";
         ConfigurationElement centralW3CLogFileElement = logSection.GetChildElement("centralW3CLogFile");
         centralW3CLogFileElement["period"] = @"Daily";

         serverManager.CommitChanges();
      }
   }
}