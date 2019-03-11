var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site";

var httpProtocolSection = adminManager.GetAdminSection("system.webServer/httpProtocol", "MACHINE/WEBROOT/APPHOST/Default Web Site");
httpProtocolSection.Properties.Item("allowKeepAlive").Value = true;

adminManager.CommitChanges();