Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set cachingSection = adminManager.GetAdminSection("system.ftpServer/caching", "MACHINE/WEBROOT/APPHOST")

Set credentialsCacheElement = cachingSection.ChildElements.Item("credentialsCache")
credentialsCacheElement.Properties.Item("enabled").Value = True
credentialsCacheElement.Properties.Item("flushInterval").Value = 300

adminManager.CommitChanges()