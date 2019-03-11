var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var aspSection = adminManager.GetAdminSection("system.webServer/asp", "MACHINE/WEBROOT/APPHOST");

var cacheElement = aspSection.ChildElements.Item("cache");
cacheElement.Properties.Item("diskTemplateCacheDirectory").Value = "%SystemDrive%\\inetpub\\temp\\ASP Compiled Templates";
cacheElement.Properties.Item("maxDiskTemplateCacheFiles").Value = 4000;
cacheElement.Properties.Item("scriptFileCacheSize").Value = 1000;
cacheElement.Properties.Item("scriptEngineCacheMax").Value = 500;

adminManager.CommitChanges();