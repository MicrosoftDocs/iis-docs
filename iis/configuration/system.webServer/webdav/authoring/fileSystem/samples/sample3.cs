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
         ConfigurationSection authoringSection = config.GetSection("system.webServer/webdav/authoring", "Default Web Site");

         ConfigurationElement fileSystemElement = authoringSection.GetChildElement("fileSystem");
         fileSystemElement["allowHiddenFiles"] = true;
         fileSystemElement["hideChildVirtualDirectories"] = true;

         serverManager.CommitChanges();
      }
   }
}