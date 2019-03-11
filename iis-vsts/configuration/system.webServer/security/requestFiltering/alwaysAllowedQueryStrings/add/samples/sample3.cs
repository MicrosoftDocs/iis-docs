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
         ConfigurationElementCollection alwaysAllowedQueryStringsCollection = requestFilteringSection.GetCollection("alwaysAllowedQueryStrings");

         ConfigurationElement addElement = alwaysAllowedQueryStringsCollection.CreateElement("add");
         addElement["queryString"] = @"allowed=sequence";
         alwaysAllowedQueryStringsCollection.Add(addElement);

         serverManager.CommitChanges();
      }
   }
}