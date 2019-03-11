var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var authenticationSection = adminManager.GetAdminSection("system.ftpServer/security/authentication", "MACHINE/WEBROOT/APPHOST");
var denyByFailureElement = authenticationSection.ChildElements.Item("denyByFailure");
denyByFailureElement.Properties.Item("enabled").Value = true;
denyByFailureElement.Properties.Item("maxFailure").Value = 10;
denyByFailureElement.Properties.Item("entryExpiration").Value = "00:00:35";
denyByFailureElement.Properties.Item("loggingOnlyMode").Value = false;

adminManager.CommitChanges();