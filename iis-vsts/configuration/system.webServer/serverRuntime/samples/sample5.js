var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var serverRuntimeSection = adminManager.GetAdminSection("system.webServer/serverRuntime", "MACHINE/WEBROOT/APPHOST/Default Web Site");
serverRuntimeSection.Properties.Item("enabled").Value = true;
serverRuntimeSection.Properties.Item("frequentHitThreshold").Value = 5;
serverRuntimeSection.Properties.Item("frequentHitTimePeriod").Value = "00:00:20";

adminManager.CommitChanges();