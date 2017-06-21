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

         ConfigurationElementCollection denyQueryStringSequencesCollection = requestFilteringSection.GetCollection("denyQueryStringSequences");
         ConfigurationElement addElement = denyQueryStringSequencesCollection.CreateElement("add");
         addElement["sequence"] = @"bad_querystring_sequence";
         denyQueryStringSequencesCollection.Add(addElement);

         serverManager.CommitChanges();
      }
   }
}