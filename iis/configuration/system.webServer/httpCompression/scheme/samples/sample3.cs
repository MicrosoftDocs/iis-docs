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
         ConfigurationSection httpCompressionSection = config.GetSection("system.webServer/httpCompression");
         ConfigurationElementCollection httpCompressionCollection = httpCompressionSection.GetCollection();

         ConfigurationElement schemeElement = httpCompressionCollection.CreateElement("scheme");
         schemeElement["name"] = @"deflate";
         schemeElement["doStaticCompression"] = true;
         schemeElement["doDynamicCompression"] = true;
         schemeElement["dll"] = @"%Windir%\system32\inetsrv\gzip.dll";
         httpCompressionCollection.Add(schemeElement);

         serverManager.CommitChanges();
      }
   }
}