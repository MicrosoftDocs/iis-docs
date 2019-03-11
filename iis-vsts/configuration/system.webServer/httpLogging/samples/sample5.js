var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var httpLoggingSection = adminManager.GetAdminSection("system.webServer/httpLogging", "MACHINE/WEBROOT/APPHOST/Contoso");
httpLoggingSection.Properties.Item("selectiveLogging").Value = "LogAll";
httpLoggingSection.Properties.Item("dontLog").Value = true;

adminManager.CommitChanges();