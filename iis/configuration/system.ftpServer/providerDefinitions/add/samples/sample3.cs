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

         serverManager.CommitChanges();
      }
   }
}