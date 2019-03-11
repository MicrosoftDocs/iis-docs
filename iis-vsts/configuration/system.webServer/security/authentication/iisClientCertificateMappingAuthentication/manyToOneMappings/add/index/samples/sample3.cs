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

         ConfigurationSection iisClientCertificateMappingAuthenticationSection = config.GetSection("system.webServer/security/authentication/iisClientCertificateMappingAuthentication", "Default Web Site");
         iisClientCertificateMappingAuthenticationSection["enabled"] = true;
         iisClientCertificateMappingAuthenticationSection["manyToOneCertificateMappingsEnabled"] = true;

         ConfigurationElementCollection manyToOneMappingsCollection = iisClientCertificateMappingAuthenticationSection.GetCollection("manyToOneMappings");
         ConfigurationElement addElement = manyToOneMappingsCollection.CreateElement("add");
         addElement["name"] = @"Contoso Employees";
         addElement["enabled"] = true;
         addElement["permissionMode"] = @"Allow";
         addElement["userName"] = @"Username";
         addElement["password"] = @"Password";

         ConfigurationElementCollection rulesCollection = addElement.GetCollection("rules");
         ConfigurationElement addElement1 = rulesCollection.CreateElement("add");
         addElement1["certificateField"] = @"Subject";
         addElement1["certificateSubField"] = @"O";
         addElement1["matchCriteria"] = @"Contoso";
         addElement1["compareCaseSensitive"] = true;
         rulesCollection.Add(addElement1);
         manyToOneMappingsCollection.Add(addElement);

         ConfigurationSection accessSection = config.GetSection("system.webServer/security/access", "Default Web Site");
         accessSection["sslFlags"] = @"Ssl, SslNegotiateCert";

         serverManager.CommitChanges();
      }
   }
}