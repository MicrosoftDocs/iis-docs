Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site"

Set staticContentSection = adminManager.GetAdminSection("system.webServer/staticContent", "MACHINE/WEBROOT/APPHOST/Default Web Site")
Set clientCacheElement = staticContentSection.ChildElements.Item("clientCache")
clientCacheElement.Properties.Item("cacheControlMode").Value = "DisableCache"

adminManager.CommitChanges()