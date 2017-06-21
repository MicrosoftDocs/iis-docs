var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var clientCertificateMappingAuthenticationSection = adminManager.GetAdminSection("system.webServer/security/authentication/clientCertificateMappingAuthentication", "MACHINE/WEBROOT/APPHOST/Default Web Site");
clientCertificateMappingAuthenticationSection.Properties.Item("enabled").Value = true;

var accessSection = adminManager.GetAdminSection("system.webServer/security/access", "MACHINE/WEBROOT/APPHOST/Default Web Site");
accessSection.Properties.Item("sslFlags").Value = "Ssl, SslNegotiateCert";

adminManager.CommitChanges();