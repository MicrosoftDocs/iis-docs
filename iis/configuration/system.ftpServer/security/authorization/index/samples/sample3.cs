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
         ConfigurationSection authorizationSection = config.GetSection("system.ftpServer/security/authorization", "Default Web Site");
         ConfigurationElementCollection authorizationCollection = authorizationSection.GetCollection();

         ConfigurationElement addElement = authorizationCollection.CreateElement("add");
         addElement["accessType"] = @"Allow";
         addElement["roles"] = @"administrators";
         addElement["permissions"] = @"Read, Write";
         authorizationCollection.Add(addElement);

         ConfigurationElement addElement1 = authorizationCollection.CreateElement("add");
         addElement1["accessType"] = @"Deny";
         addElement1["users"] = @"guest";
         addElement1["permissions"] = @"Read, Write";
         authorizationCollection.Add(addElement1);

         serverManager.CommitChanges();
      }
   }
}