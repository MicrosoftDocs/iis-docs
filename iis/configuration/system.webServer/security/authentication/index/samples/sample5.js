var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var anonymousAuthenticationSection = adminManager.GetAdminSection("system.webServer/security/authentication/anonymousAuthentication", "MACHINE/WEBROOT/APPHOST/Contoso");
anonymousAuthenticationSection.Properties.Item("enabled").Value = false;

var basicAuthenticationSection = adminManager.GetAdminSection("system.webServer/security/authentication/basicAuthentication", "MACHINE/WEBROOT/APPHOST/Contoso");
basicAuthenticationSection.Properties.Item("enabled").Value = true;

var windowsAuthenticationSection = adminManager.GetAdminSection("system.webServer/security/authentication/windowsAuthentication", "MACHINE/WEBROOT/APPHOST/Contoso");
windowsAuthenticationSection.Properties.Item("enabled").Value = true;

adminManager.CommitChanges();