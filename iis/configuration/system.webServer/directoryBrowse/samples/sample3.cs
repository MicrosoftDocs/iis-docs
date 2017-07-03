using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample {
   private static void Main() {
      using(ServerManager serverManager = new ServerManager()) { 
         Configuration config = serverManager.GetWebConfiguration("Contoso");

         ConfigurationSection directoryBrowseSection = config.GetSection("system.webServer/directoryBrowse");
         directoryBrowseSection["enabled"] = true;
         directoryBrowseSection["showFlags"] = @"Date, Time, Size, Extension";

         serverManager.CommitChanges();
      }
   }
}