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
         ConfigurationSection staticContentSection = config.GetSection("system.webServer/staticContent");
         ConfigurationElementCollection staticContentCollection = staticContentSection.GetCollection();

         ConfigurationElement mimeMapElement = staticContentCollection.CreateElement("mimeMap");
         mimeMapElement["fileExtension"] = @"syx";
         mimeMapElement["mimeType"] = @"application/octet-stream";
         staticContentCollection.Add(mimeMapElement);

         ConfigurationElement mimeMapElement1 = staticContentCollection.CreateElement("mimeMap");
         mimeMapElement1["fileExtension"] = @"tab";
         mimeMapElement1["mimeType"] = @"text/plain";
         staticContentCollection.Add(mimeMapElement1);

         serverManager.CommitChanges();
      }
   }
}