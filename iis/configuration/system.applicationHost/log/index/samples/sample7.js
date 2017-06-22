var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var logSection = adminManager.GetAdminSection("system.applicationHost/log", "MACHINE/WEBROOT/APPHOST");
logSection.Properties.Item("centralLogFileMode").Value = "CentralBinary";
var centralBinaryLogFileElement = logSection.ChildElements.Item("centralBinaryLogFile");
centralBinaryLogFileElement.Properties.Item("period").Value = "Daily";

adminManager.CommitChanges();