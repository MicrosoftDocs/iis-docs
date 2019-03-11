var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var cachingSection = adminManager.GetAdminSection("system.ftpServer/caching", "MACHINE/WEBROOT/APPHOST");

var credentialsCacheElement = cachingSection.ChildElements.Item("credentialsCache");
credentialsCacheElement.Properties.Item("enabled").Value = true;
credentialsCacheElement.Properties.Item("flushInterval").Value = 300;

adminManager.CommitChanges();