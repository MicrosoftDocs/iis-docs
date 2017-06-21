using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample
{
   private static void Main()
   {
      using (ServerManager serverManager = new ServerManager())
      {
         Configuration config = serverManager.GetRedirectionConfiguration();
         ConfigurationSection redirectionSection = config.GetSection("configurationRedirection");

         redirectionSection.Attributes["enabled"].Value = true;
         redirectionSection.Attributes["path"].Value = @"\\SeverName\ShareName";
         redirectionSection.Attributes["userName"].Value = @"MyUser";
         redirectionSection.Attributes["password"].Value = @"P@ssw0rd";

         serverManager.CommitChanges();
      }
   }
}