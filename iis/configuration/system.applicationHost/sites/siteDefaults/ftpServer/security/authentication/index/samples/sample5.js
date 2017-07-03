var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST");
var siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults");
var ftpServerElement = siteDefaultsElement.ChildElements.Item("ftpServer");

var securityElement = ftpServerElement.ChildElements.Item("security");
var authenticationElement = securityElement.ChildElements.Item("authentication");
var anonymousAuthenticationElement = authenticationElement.ChildElements.Item("anonymousAuthentication");
   anonymousAuthenticationElement.Properties.Item("enabled").Value = false;
var basicAuthenticationElement = authenticationElement.ChildElements.Item("basicAuthentication");
   basicAuthenticationElement.Properties.Item("enabled").Value = true;

adminManager.CommitChanges();