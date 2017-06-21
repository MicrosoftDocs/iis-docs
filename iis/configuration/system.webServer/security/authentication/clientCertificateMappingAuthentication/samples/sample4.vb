Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration

      Dim clientCertificateMappingAuthenticationSection As ConfigurationSection = config.GetSection("system.webServer/security/authentication/clientCertificateMappingAuthentication", "Default Web Site")
      clientCertificateMappingAuthenticationSection("enabled") = True

      Dim accessSection As ConfigurationSection = config.GetSection("system.webServer/security/access", "Default Web Site")
      accessSection("sslFlags") = "Ssl, SslNegotiateCert"

      serverManager.CommitChanges()
   End Sub

End Module