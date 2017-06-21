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

         ConfigurationElement verbsElement = requestFilteringSection.GetChildElement("verbs");
         verbsElement["applyToWebDAV"] = false;
         ConfigurationElementCollection verbsCollection = verbsElement.GetCollection();

         ConfigurationElement addElement = verbsCollection.CreateElement("add");
         addElement["verb"] = @"PUT";
         addElement["allowed"] = false;
         verbsCollection.Add(addElement);

         serverManager.CommitChanges();
      }
   }
}