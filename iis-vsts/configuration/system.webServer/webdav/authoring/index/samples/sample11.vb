Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set authoringSection = adminManager.GetAdminSection("system.webServer/webdav/authoring", "MACHINE/WEBROOT/APPHOST/Default Web Site")
Set locksElement = authoringSection.ChildElements.Item("locks")
locksElement.Properties.Item("enabled").Value = True
locksElement.Properties.Item("lockStore").Value = "webdav_simple_lock"
locksElement.Properties.Item("requireLockForWriting").Value = False

adminManager.CommitChanges()