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
         logSection["centralLogFileMode"] = @"CentralBinary";
         ConfigurationElement centralBinaryLogFileElement = logSection.GetChildElement("centralBinaryLogFile");
         centralBinaryLogFileElement["period"] = @"Daily";

         serverManager.CommitChanges();
      }
   }
}