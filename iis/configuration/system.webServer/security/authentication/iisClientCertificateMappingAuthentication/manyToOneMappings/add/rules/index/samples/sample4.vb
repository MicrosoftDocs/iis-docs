Imports System
Imports System.Text
Imports Microsoft.Web.Administration

Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration

      Dim iisClientCertificateMappingAuthenticationSection As ConfigurationSection = config.GetSection("system.webServer/security/authentication/iisClientCertificateMappingAuthentication", "Default Web Site")
      iisClientCertificateMappingAuthenticationSection("enabled") = True
      iisClientCertificateMappingAuthenticationSection("manyToOneCertificateMappingsEnabled") = True

      Dim manyToOneMappingsCollection As ConfigurationElementCollection = iisClientCertificateMappingAuthenticationSection.GetCollection("manyToOneMappings")
      Dim addElement As ConfigurationElement = manyToOneMappingsCollection.CreateElement("add")
      addElement("name") = "Contoso Employees"
      addElement("enabled") = True
      addElement("permissionMode") = "Allow"
      addElement("userName") = "Username"
      addElement("password") = "Password"

      Dim rulesCollection As ConfigurationElementCollection = addElement.GetCollection("rules")
      Dim addElement1 As ConfigurationElement = rulesCollection.CreateElement("add")
      addElement1("certificateField") = "Subject"
      addElement1("certificateSubField") = "O"
      addElement1("matchCriteria") = "Contoso"
      addElement1("compareCaseSensitive") = True
      rulesCollection.Add(addElement1)
      manyToOneMappingsCollection.Add(addElement)

      Dim accessSection As ConfigurationSection = config.GetSection("system.webServer/security/access", "Default Web Site")
      accessSection("sslFlags") = "Ssl, SslNegotiateCert"

      serverManager.CommitChanges()
   End Sub

End Module