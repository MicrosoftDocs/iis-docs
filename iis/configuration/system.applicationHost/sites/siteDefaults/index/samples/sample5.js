var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST");
var siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults");

var limitsElement = siteDefaultsElement.ChildElements.Item("limits");
limitsElement.Properties.Item("connectionTimeout").Value = "00:02:00";

var logFileElement = siteDefaultsElement.ChildElements.Item("logFile");
logFileElement.Properties.Item("logFormat").Value = "W3C";
logFileElement.Properties.Item("directory").Value = "%SystemDrive%\\inetpub\\logs\\LogFiles";
logFileElement.Properties.Item("enabled").Value = true;

var traceFailedRequestsLoggingElement = siteDefaultsElement.ChildElements.Item("traceFailedRequestsLogging");
traceFailedRequestsLoggingElement.Properties.Item("enabled").Value = true;
traceFailedRequestsLoggingElement.Properties.Item("directory").Value = "%SystemDrive%\\inetpub\\logs\\FailedReqLogFiles";
traceFailedRequestsLoggingElement.Properties.Item("maxLogFiles").Value = 20;

var bindingsCollection = siteDefaultsElement.ChildElements.Item("bindings").Collection;
var bindingElement = bindingsCollection.CreateNewElement("binding");
bindingElement.Properties.Item("protocol").Value = "http";
bindingElement.Properties.Item("bindingInformation").Value = "127.0.0.1:8080:";
bindingsCollection.AddElement(bindingElement);

var ftpServerElement = siteDefaultsElement.ChildElements.Item("ftpServer");
ftpServerElement.Properties.Item("serverAutoStart").Value = true;

adminManager.CommitChanges();