var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var serverSideIncludeSection = adminManager.GetAdminSection("system.webServer/serverSideInclude", "MACHINE/WEBROOT/APPHOST/Default Web Site");
serverSideIncludeSection.Properties.Item("ssiExecDisable").Value = true;

adminManager.CommitChanges();