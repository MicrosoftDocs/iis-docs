Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set iisClientCertificateMappingAuthenticationSection = adminManager.GetAdminSection("system.webServer/security/authentication/iisClientCertificateMappingAuthentication", "MACHINE/WEBROOT/APPHOST/Default Web Site")
iisClientCertificateMappingAuthenticationSection.Properties.Item("enabled").Value = True
iisClientCertificateMappingAuthenticationSection.Properties.Item("oneToOneCertificateMappingsEnabled").Value = True

Set oneToOneMappingsCollection = iisClientCertificateMappingAuthenticationSection.ChildElements.Item("oneToOneMappings").Collection
Set addElement = oneToOneMappingsCollection.CreateNewElement("add")
addElement.Properties.Item("enabled").Value = True
addElement.Properties.Item("userName").Value = "Username"
addElement.Properties.Item("password").Value = "Password"
addElement.Properties.Item("certificate").Value = "Base-64-Encoded-Certificate-Data"
oneToOneMappingsCollection.AddElement(addElement)

Set accessSection = adminManager.GetAdminSection("system.webServer/security/access", "MACHINE/WEBROOT/APPHOST/Default Web Site")
accessSection.Properties.Item("sslFlags").Value = "Ssl, SslNegotiateCert"

adminManager.CommitChanges()