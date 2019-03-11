var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST");
var siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults");
var ftpServerElement = siteDefaultsElement.ChildElements.Item("ftpServer");

var firewallSupportElement = ftpServerElement.ChildElements.Item("firewallSupport");
   firewallSupportElement.Properties.Item("externalIp4Address").Value = "169.254.10.10";

adminManager.CommitChanges();