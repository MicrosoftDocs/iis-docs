Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration

      Dim iisClientCertificateMappingAuthenticationSection As ConfigurationSection = config.GetSection("system.webServer/security/authentication/iisClientCertificateMappingAuthentication", "Default Web Site")
      iisClientCertificateMappingAuthenticationSection("enabled") = True
      iisClientCertificateMappingAuthenticationSection("oneToOneCertificateMappingsEnabled") = True

      Dim oneToOneMappingsCollection As ConfigurationElementCollection = iisClientCertificateMappingAuthenticationSection.GetCollection("oneToOneMappings")
      Dim addElement As ConfigurationElement = oneToOneMappingsCollection.CreateElement("add")
      addElement("enabled") = True
      addElement("userName") = "Username"
      addElement("password") = "Password"
      addElement("certificate") = "Base-64-Encoded-Certificate-Data"
      oneToOneMappingsCollection.Add(addElement)

      Dim accessSection As ConfigurationSection = config.GetSection("system.webServer/security/access", "Default Web Site")
      accessSection("sslFlags") = "Ssl, SslNegotiateCert"

      serverManager.CommitChanges()
   End Sub

End Module