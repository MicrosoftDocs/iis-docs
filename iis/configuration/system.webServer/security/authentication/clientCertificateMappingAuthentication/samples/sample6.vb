Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set clientCertificateMappingAuthenticationSection = adminManager.GetAdminSection("system.webServer/security/authentication/clientCertificateMappingAuthentication", "MACHINE/WEBROOT/APPHOST/Default Web Site")
clientCertificateMappingAuthenticationSection.Properties.Item("enabled").Value = True

Set accessSection = adminManager.GetAdminSection("system.webServer/security/access", "MACHINE/WEBROOT/APPHOST/Default Web Site")
accessSection.Properties.Item("sslFlags").Value = "Ssl, SslNegotiateCert"

adminManager.CommitChanges()