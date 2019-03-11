var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var basicAuthenticationSection = adminManager.GetAdminSection("system.webServer/security/authentication/basicAuthentication", "MACHINE/WEBROOT/APPHOST/Contoso");
basicAuthenticationSection.Properties.Item("enabled").Value = true;

adminManager.CommitChanges();