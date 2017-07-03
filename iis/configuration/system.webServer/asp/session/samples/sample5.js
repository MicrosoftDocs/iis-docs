var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var aspSection = adminManager.GetAdminSection("system.webServer/asp", "MACHINE/WEBROOT/APPHOST/Default Web Site");

var sessionElement = aspSection.ChildElements.Item("session");
sessionElement.Properties.Item("allowSessionState").Value = true;
sessionElement.Properties.Item("max").Value = 1000;
sessionElement.Properties.Item("timeout").Value = "00:10:00";

adminManager.CommitChanges();