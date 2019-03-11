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
         ConfigurationElement fileExtensionsElement = requestFilteringSection.GetChildElement("fileExtensions");
         ConfigurationElementCollection fileExtensionsCollection = fileExtensionsElement.GetCollection();

         ConfigurationElement addElement = fileExtensionsCollection.CreateElement("add");
         addElement["fileExtension"] = @".exe";
         addElement["allowed"] = false;
         fileExtensionsCollection.Add(addElement);

         ConfigurationElement addElement1 = fileExtensionsCollection.CreateElement("add");
         addElement1["fileExtension"] = @".com";
         addElement1["allowed"] = false;
         fileExtensionsCollection.Add(addElement1);

         ConfigurationElement addElement2 = fileExtensionsCollection.CreateElement("add");
         addElement2["fileExtension"] = @".cmd";
         addElement2["allowed"] = false;
         fileExtensionsCollection.Add(addElement2);

         ConfigurationElement addElement3 = fileExtensionsCollection.CreateElement("add");
         addElement3["fileExtension"] = @".bat";
         addElement3["allowed"] = false;
         fileExtensionsCollection.Add(addElement3);

         serverManager.CommitChanges();
      }
   }
}