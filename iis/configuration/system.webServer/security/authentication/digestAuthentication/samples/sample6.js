var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var digestAuthenticationSection = adminManager.GetAdminSection("system.webServer/security/authentication/digestAuthentication", "MACHINE/WEBROOT/APPHOST/Contoso");
digestAuthenticationSection.Properties.Item("enabled").Value = true;

adminManager.CommitChanges();