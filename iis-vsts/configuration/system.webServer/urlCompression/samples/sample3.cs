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

         ConfigurationSection urlCompressionSection = config.GetSection("system.webServer/urlCompression");
         urlCompressionSection["doStaticCompression"] = true;
         urlCompressionSection["doDynamicCompression"] = false;

         serverManager.CommitChanges();
      }
   }
}