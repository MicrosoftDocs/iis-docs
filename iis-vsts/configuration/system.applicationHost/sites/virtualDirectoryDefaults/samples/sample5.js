var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST");
var virtualDirectoryDefaultsElement = sitesSection.ChildElements.Item("virtualDirectoryDefaults");
virtualDirectoryDefaultsElement.Properties.Item("logonMethod").Value = "Network";

adminManager.CommitChanges();