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

         ConfigurationSection authoringRulesSection = config.GetSection("system.webServer/webdav/authoringRules", "Default Web Site");
         authoringRulesSection["allowNonMimeMapFiles"] = true;

         ConfigurationElementCollection authoringRulesCollection = authoringRulesSection.GetCollection();

         ConfigurationElement addElement = authoringRulesCollection.CreateElement("add");
         addElement["roles"] = @"administrators";
         addElement["path"] = @"*";
         addElement["access"] = @"Read, Write, Source";
         authoringRulesCollection.Add(addElement);

         serverManager.CommitChanges();
      }
   }
}