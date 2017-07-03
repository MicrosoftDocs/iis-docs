var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var webSocketSection = adminManager.GetAdminSection("system.webServer/webSocket", "MACHINE/WEBROOT/APPHOST/Default Web Site");
webSocketSection.Properties.Item("enabled").Value = true;
webSocketSection.Properties.Item("receiveBufferLimit").Value = 4194304;
webSocketSection.Properties.Item("pingInterval").Value = "00:00:10";

adminManager.CommitChanges();