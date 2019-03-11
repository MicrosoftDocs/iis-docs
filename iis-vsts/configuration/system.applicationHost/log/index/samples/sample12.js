var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var logSection = adminManager.GetAdminSection("system.applicationHost/log", "MACHINE/WEBROOT/APPHOST");
logSection.Properties.Item("centralLogFileMode").Value = "CentralW3C";
var centralW3CLogFileElement = logSection.ChildElements.Item("centralW3CLogFile");
centralW3CLogFileElement.Properties.Item("period").Value = "Daily";

adminManager.CommitChanges();