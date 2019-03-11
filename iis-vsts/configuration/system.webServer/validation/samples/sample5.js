var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site";

var validationSection = adminManager.GetAdminSection("system.webServer/validation", "MACHINE/WEBROOT/APPHOST/Default Web Site");
validationSection.Properties.Item("validateIntegratedModeConfiguration").Value = true;

adminManager.CommitChanges();