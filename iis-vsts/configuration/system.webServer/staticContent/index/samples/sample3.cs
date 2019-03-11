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
         staticContentSection["defaultDocFooter"] = @"The information in this web site is copyrighted.";
         staticContentSection["enableDocFooter"] = true;

         serverManager.CommitChanges();
      }
   }
}