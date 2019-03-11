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
         ConfigurationSection sitesSection = config.GetSection("system.applicationHost/sites");
         ConfigurationElementCollection sitesCollection = sitesSection.GetCollection();

         ConfigurationElement siteElement = sitesCollection.CreateElement("site");
         siteElement["name"] = @"Contoso";
         siteElement["id"] = 2;
         siteElement["serverAutoStart"] = true;

         ConfigurationElementCollection bindingsCollection = siteElement.GetCollection("bindings");
         ConfigurationElement bindingElement = bindingsCollection.CreateElement("binding");
         bindingElement["protocol"] = @"http";
         bindingElement["bindingInformation"] = @"*:80:www.contoso.com";
         bindingsCollection.Add(bindingElement);

         ConfigurationElementCollection siteCollection = siteElement.GetCollection();
         ConfigurationElement applicationElement = siteCollection.CreateElement("application");
         applicationElement["path"] = @"/";
         ConfigurationElementCollection applicationCollection = applicationElement.GetCollection();
         ConfigurationElement virtualDirectoryElement = applicationCollection.CreateElement("virtualDirectory");
         virtualDirectoryElement["path"] = @"/";
         virtualDirectoryElement["physicalPath"] = @"C:\Inetpub\www.contoso.com\wwwroot";
         applicationCollection.Add(virtualDirectoryElement);
         siteCollection.Add(applicationElement);
         sitesCollection.Add(siteElement);

         serverManager.CommitChanges();
      }
   }
}