var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST");
var siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults");
var ftpServerElement = siteDefaultsElement.ChildElements.Item("ftpServer");
var securityElement = ftpServerElement.ChildElements.Item("security");
var customAuthorizationElement = securityElement.ChildElements.Item("customAuthorization");
var providerElement = customAuthorizationElement.ChildElements.Item("provider");
providerElement.Properties.Item("name").Value = "MyCustomProvider";
providerElement.Properties.Item("enabled").Value = true;

adminManager.CommitChanges();