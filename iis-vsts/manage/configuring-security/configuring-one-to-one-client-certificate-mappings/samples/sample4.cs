using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample {

    private static void Main() {
        
        using(ServerManager serverManager = new ServerManager()) { 
            Configuration config = serverManager.GetApplicationHostConfiguration();
            
            ConfigurationSection iisClientCertificateMappingAuthenticationSection = 
                    config.GetSection("system.webServer/security/authentication/iisClientCertificateMappingAuthentication", "Default Web Site");
            iisClientCertificateMappingAuthenticationSection["enabled"] = true;
            iisClientCertificateMappingAuthenticationSection["oneToOneCertificateMappingsEnabled"] = true;
            
            ConfigurationElementCollection oneToOneMappingsCollection = 
                     iisClientCertificateMappingAuthenticationSection.GetCollection("oneToOneMappings");
            
            ConfigurationElement addElement = oneToOneMappingsCollection.CreateElement("add");
            addElement["userName"] = @"testUser";
            addElement["password"] = @"securePassWord!1";
            addElement["certificate"] = @"CERTIFICATE_BLOB";
            oneToOneMappingsCollection.Add(addElement);
            
            serverManager.CommitChanges();
        }
    }
}

using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample {

    private static void Main() {
        
        using(ServerManager serverManager = new ServerManager()) { 
            Configuration config = serverManager.GetApplicationHostConfiguration();
            
            ConfigurationSection accessSection = config.GetSection("system.webServer/security/access", "Default Web Site");
            accessSection["sslFlags"] = @"Ssl, SslNegotiateCert, Ssl128";
            
            serverManager.CommitChanges();
        }
    }
}