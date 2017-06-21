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
         ConfigurationSection providerDefinitionsSection = config.GetSection("system.ftpServer/providerDefinitions");
         ConfigurationElementCollection providerDefinitionsCollection = providerDefinitionsSection.GetCollection();

         ConfigurationElement addElement = providerDefinitionsCollection.CreateElement("add");
         addElement["name"] = @"FtpXmlAuthentication";
         addElement["type"] = @"FtpXmlAuthentication, FtpXmlAuthentication, version=1.0.0.0, Culture=neutral, PublicKeyToken=426f62526f636b73";
         providerDefinitionsCollection.Add(addElement);

         ConfigurationElementCollection activationCollection = providerDefinitionsSection.GetCollection("activation");
         ConfigurationElement providerDataElement = activationCollection.CreateElement("providerData");
         providerDataElement["name"] = @"FtpXmlAuthentication";

         ConfigurationElementCollection providerDataCollection = providerDataElement.GetCollection();
         ConfigurationElement addElement1 = providerDataCollection.CreateElement("add");
         addElement1["key"] = @"xmlFileName";
         addElement1["value"] = @"C:\Inetpub\wwwroot\App_Data\Users.xml";
         providerDataCollection.Add(addElement1);
         activationCollection.Add(providerDataElement);

         serverManager.CommitChanges();
      }
   }
}