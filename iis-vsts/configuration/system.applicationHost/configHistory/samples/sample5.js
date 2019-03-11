var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var configHistorySection = adminManager.GetAdminSection("system.applicationHost/configHistory", "MACHINE/WEBROOT/APPHOST");
configHistorySection.Properties.Item("enabled").Value = true;
configHistorySection.Properties.Item("path").Value = "%SystemDrive%\\inetpub\\history";
configHistorySection.Properties.Item("maxHistories").Value = 50;
configHistorySection.Properties.Item("period").Value = "00:05:00";

adminManager.CommitChanges();