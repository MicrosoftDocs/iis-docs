var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var iisClientCertificateMappingAuthenticationSection = adminManager.GetAdminSection("system.webServer/security/authentication/iisClientCertificateMappingAuthentication", "MACHINE/WEBROOT/APPHOST/Default Web Site");
iisClientCertificateMappingAuthenticationSection.Properties.Item("enabled").Value = true;
iisClientCertificateMappingAuthenticationSection.Properties.Item("oneToOneCertificateMappingsEnabled").Value = true;

var oneToOneMappingsCollection = iisClientCertificateMappingAuthenticationSection.ChildElements.Item("oneToOneMappings").Collection;
var addElement = oneToOneMappingsCollection.CreateNewElement("add");
addElement.Properties.Item("enabled").Value = true;
addElement.Properties.Item("userName").Value = "Username";
addElement.Properties.Item("password").Value = "Password";
addElement.Properties.Item("certificate").Value = "Base-64-Encoded-Certificate-Data";
oneToOneMappingsCollection.AddElement(addElement);

var accessSection = adminManager.GetAdminSection("system.webServer/security/access", "MACHINE/WEBROOT/APPHOST/Default Web Site");
accessSection.Properties.Item("sslFlags").Value = "Ssl, SslNegotiateCert";

adminManager.CommitChanges();