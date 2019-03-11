Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site"

Set staticContentSection = adminManager.GetAdminSection("system.webServer/staticContent", "MACHINE/WEBROOT/APPHOST/Default Web Site")
Set clientCacheElement = staticContentSection.ChildElements.Item("clientCache")
clientCacheElement.Properties.Item("cacheControlMode").Value = "UseExpires"
clientCacheElement.Properties.Item("httpExpires").Value = "Tue, 19 Jan 2038 03:14:07 GMT"

adminManager.CommitChanges()