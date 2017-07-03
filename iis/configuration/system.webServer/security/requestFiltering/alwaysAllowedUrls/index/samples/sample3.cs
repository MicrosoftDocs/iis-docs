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
         ConfigurationSection requestFilteringSection = config.GetSection("system.webServer/security/requestFiltering");
         ConfigurationElementCollection alwaysAllowedUrlsCollection = requestFilteringSection.GetCollection("alwaysAllowedUrls");

         ConfigurationElement addElement = alwaysAllowedUrlsCollection.CreateElement("add");
         addElement["url"] = @"/allowed_url.aspx";
         alwaysAllowedUrlsCollection.Add(addElement);

         serverManager.CommitChanges();
      }
   }
}