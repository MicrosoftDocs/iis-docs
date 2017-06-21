Set adminManager = CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set webSocketSection = adminManager.GetAdminSection("system.webServer/webSocket", "MACHINE/WEBROOT/APPHOST/Default Web Site")
webSocketSection.Properties.Item("enabled").Value = true
webSocketSection.Properties.Item("receiveBufferLimit").Value = 4194303
webSocketSection.Properties.Item("pingInterval").Value = "00:00:20"

adminManager.CommitChanges()