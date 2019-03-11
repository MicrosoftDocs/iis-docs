var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var authoringSection = adminManager.GetAdminSection("system.webServer/webdav/authoring", "MACHINE/WEBROOT/APPHOST/Default Web Site");
var locksElement = authoringSection.ChildElements.Item("locks");
locksElement.Properties.Item("enabled").Value = true;
locksElement.Properties.Item("lockStore").Value = "webdav_simple_lock";
locksElement.Properties.Item("requireLockForWriting").Value = false;

adminManager.CommitChanges();