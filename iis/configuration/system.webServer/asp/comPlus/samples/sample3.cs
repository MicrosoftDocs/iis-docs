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
         ConfigurationSection aspSection = config.GetSection("system.webServer/asp", "Default Web Site");

         ConfigurationElement comPlusElement = aspSection.GetChildElement("comPlus");
         comPlusElement["trackThreadingModel"] = true;
         comPlusElement["executeInMta"] = true;

         serverManager.CommitChanges();
      }
   }
}