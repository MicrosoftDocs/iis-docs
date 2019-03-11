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

         ConfigurationElementCollection denyUrlSequencesCollection = requestFilteringSection.GetCollection("denyUrlSequences");

         ConfigurationElement addElement = denyUrlSequencesCollection.CreateElement("add");
         addElement["sequence"] = @"..";
         denyUrlSequencesCollection.Add(addElement);

         ConfigurationElement addElement1 = denyUrlSequencesCollection.CreateElement("add");
         addElement1["sequence"] = @":";
         denyUrlSequencesCollection.Add(addElement1);

         ConfigurationElement addElement2 = denyUrlSequencesCollection.CreateElement("add");
         addElement2["sequence"] = @"\";
         denyUrlSequencesCollection.Add(addElement2);

         serverManager.CommitChanges();
      }
   }
}