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
         ConfigurationSection isapiFiltersSection = config.GetSection("system.webServer/isapiFilters");
         ConfigurationElementCollection isapiFiltersCollection = isapiFiltersSection.GetCollection();

         ConfigurationElement filterElement = isapiFiltersCollection.CreateElement("filter");
         filterElement["name"] = @"SalesQueryIsapi";
         filterElement["path"] = @"c:\Inetpub\www.contoso.com\filters\SalesQueryIsapi.dll";
         filterElement["enabled"] = true;
         filterElement["enableCache"] = true;
         isapiFiltersCollection.Add(filterElement);

         serverManager.CommitChanges();
      }
   }
}