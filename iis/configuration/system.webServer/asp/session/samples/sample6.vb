Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set aspSection = adminManager.GetAdminSection("system.webServer/asp", "MACHINE/WEBROOT/APPHOST/Default Web Site")

Set sessionElement = aspSection.ChildElements.Item("session")
sessionElement.Properties.Item("allowSessionState").Value = True
sessionElement.Properties.Item("max").Value = 1000
sessionElement.Properties.Item("timeout").Value = "00:10:00"

adminManager.CommitChanges()