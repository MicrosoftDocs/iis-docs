Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set aspSection = adminManager.GetAdminSection("system.webServer/asp", "MACHINE/WEBROOT/APPHOST")
Set limitsElement = aspSection.ChildElements.Item("limits")
limitsElement.Properties.Item("scriptTimeout").Value = "00:02:00"
limitsElement.Properties.Item("queueConnectionTestTime").Value = "00:00:05"
limitsElement.Properties.Item("requestQueueMax").Value = 1000

adminManager.CommitChanges()