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
         ConfigurationSection serverRuntimeSection = config.GetSection("system.ftpServer/serverRuntime");

         ConfigurationElement hostNameSupportElement = serverRuntimeSection.GetChildElement("hostNameSupport");
         hostNameSupportElement["useDomainNameAsHostName"] = true;

         serverManager.CommitChanges();
      }
   }
}