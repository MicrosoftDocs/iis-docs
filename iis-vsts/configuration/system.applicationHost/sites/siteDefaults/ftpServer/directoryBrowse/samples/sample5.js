var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST");
var siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults");
var ftpServerElement = siteDefaultsElement.ChildElements.Item("ftpServer");

var directoryBrowseElement = ftpServerElement.ChildElements.Item("directoryBrowse");
   directoryBrowseElement.Properties.Item("showFlags").Value = "StyleUnix, DisplayAvailableBytes";

adminManager.CommitChanges();