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
         ConfigurationSection cachingSection = config.GetSection("system.ftpServer/caching");

         ConfigurationElement credentialsCacheElement = cachingSection.GetChildElement("credentialsCache");
         credentialsCacheElement["enabled"] = true;
         credentialsCacheElement["flushInterval"] = 300;

         serverManager.CommitChanges();
      }
   }
}