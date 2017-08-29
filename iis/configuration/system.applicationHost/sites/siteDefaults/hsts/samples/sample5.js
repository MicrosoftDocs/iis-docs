var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST");
var siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults");

var hstsElement = siteDefaultsElement.ChildElements.Item("hsts");
hstsElement.Properties.Item("enabled").Value = true;
hstsElement.Properties.Item("max-age").Value = 31536000;
hstsElement.Properties.Item("includeSubDomains").Value = true;
hstsElement.Properties.Item("redirectHttpToHttps").Value = true;

adminManager.CommitChanges();