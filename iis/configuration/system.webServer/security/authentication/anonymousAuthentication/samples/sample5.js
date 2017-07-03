var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var anonymousAuthenticationSection = adminManager.GetAdminSection("system.webServer/security/authentication/anonymousAuthentication", "MACHINE/WEBROOT/APPHOST/Contoso");
anonymousAuthenticationSection.Properties.Item("enabled").Value = true;
anonymousAuthenticationSection.Properties.Item("userName").Value = "IUSR";
anonymousAuthenticationSection.Properties.Item("password").Value = "P@ssw0rd";

adminManager.CommitChanges();