var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST");
var siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults");

var limitsElement = siteDefaultsElement.ChildElements.Item("limits");
limitsElement.Properties.Item("connectionTimeout").Value = "00:03:00";

adminManager.CommitChanges();