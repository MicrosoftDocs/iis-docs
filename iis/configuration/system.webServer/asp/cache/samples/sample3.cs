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
         ConfigurationSection aspSection = config.GetSection("system.webServer/asp");

         ConfigurationElement cacheElement = aspSection.GetChildElement("cache");
         cacheElement["diskTemplateCacheDirectory"] = @"%SystemDrive%\inetpub\temp\ASP Compiled Templates";
         cacheElement["maxDiskTemplateCacheFiles"] = 4000;
         cacheElement["scriptFileCacheSize"] = 1000;
         cacheElement["scriptEngineCacheMax"] = 500;

         serverManager.CommitChanges();
      }
   }
}