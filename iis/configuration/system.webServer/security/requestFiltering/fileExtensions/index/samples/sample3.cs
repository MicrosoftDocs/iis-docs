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

         ConfigurationElement fileExtensionsElement = requestFilteringSection.GetChildElement("fileExtensions");
         fileExtensionsElement["applyToWebDAV"] = false;
         ConfigurationElementCollection fileExtensionsCollection = fileExtensionsElement.GetCollection();

         ConfigurationElement addElement = fileExtensionsCollection.CreateElement("add");
         addElement["fileExtension"] = @"inc";
         addElement["allowed"] = false;
         fileExtensionsCollection.Add(addElement);

         serverManager.CommitChanges();
      }
   }
}