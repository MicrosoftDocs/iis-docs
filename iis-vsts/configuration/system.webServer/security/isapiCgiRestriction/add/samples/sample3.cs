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
         ConfigurationSection isapiCgiRestrictionSection = config.GetSection("system.webServer/security/isapiCgiRestriction");
         ConfigurationElementCollection isapiCgiRestrictionCollection = isapiCgiRestrictionSection.GetCollection();

         ConfigurationElement addElement = isapiCgiRestrictionCollection.CreateElement("add");
         addElement["path"] = @"C:\Inetpub\www.contoso.com\wwwroot\isapi\custom.dll";
         addElement["allowed"] = true;
         addElement["groupId"] = @"ContosoGroup";
         addElement["description"] = @"Contoso Extension";
         isapiCgiRestrictionCollection.Add(addElement);

         serverManager.CommitChanges();
      }
   }
}