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
         ConfigurationSection requestFilteringSection = config.GetSection("system.ftpServer/security/requestFiltering", "Default Web Site");
         ConfigurationElementCollection denyUrlSequencesCollection = requestFilteringSection.GetCollection("denyUrlSequences");

         ConfigurationElement addElement = denyUrlSequencesCollection.CreateElement("add");
         addElement["sequence"] = @"bin";
         denyUrlSequencesCollection.Add(addElement);

         serverManager.CommitChanges();
      }
   }
}