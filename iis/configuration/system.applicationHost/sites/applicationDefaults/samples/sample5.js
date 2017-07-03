var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST");

var applicationDefaultsElement = sitesSection.ChildElements.Item("applicationDefaults");
applicationDefaultsElement.Properties.Item("applicationPool").Value = "DefaultAppPool";

adminManager.CommitChanges();