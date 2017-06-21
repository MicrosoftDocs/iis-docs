var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var authoringSection = adminManager.GetAdminSection("system.webServer/webdav/authoring", "MACHINE/WEBROOT/APPHOST/Default Web Site");
authoringSection.Properties.Item("enabled").Value = true;
authoringSection.Properties.Item("requireSsl").Value = false;

adminManager.CommitChanges();