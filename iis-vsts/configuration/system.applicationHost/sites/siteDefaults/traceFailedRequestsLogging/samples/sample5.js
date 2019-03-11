var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST");
var siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults");

var traceFailedRequestsLoggingElement = siteDefaultsElement.ChildElements.Item("traceFailedRequestsLogging");
traceFailedRequestsLoggingElement.Properties.Item("enabled").Value = true;
traceFailedRequestsLoggingElement.Properties.Item("directory").Value = "%SystemDrive%\\inetpub\\logs\\FailedReqLogFiles";
traceFailedRequestsLoggingElement.Properties.Item("maxLogFiles").Value = 20;

adminManager.CommitChanges();