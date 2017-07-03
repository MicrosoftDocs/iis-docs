var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST");
var siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults");
var ftpServerElement = siteDefaultsElement.ChildElements.Item("ftpServer");

var messagesElement = ftpServerElement.ChildElements.Item("messages");
   messagesElement.Properties.Item("bannerMessage").Value = "Welcome!";
   messagesElement.Properties.Item("allowLocalDetailedErrors").Value = true;

adminManager.CommitChanges();