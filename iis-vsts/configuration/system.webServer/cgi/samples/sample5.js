var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var cgiSection = adminManager.GetAdminSection("system.webServer/cgi", "MACHINE/WEBROOT/APPHOST/Default Web Site");

cgiSection.Properties.Item("createCGIWithNewConsole").Value = true;
cgiSection.Properties.Item("createProcessAsUser").Value = false;
cgiSection.Properties.Item("timeout").Value = "00:20:00";

adminManager.CommitChanges();