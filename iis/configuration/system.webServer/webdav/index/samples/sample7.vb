Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set authoringSection = adminManager.GetAdminSection("system.webServer/webdav/authoring", "MACHINE/WEBROOT/APPHOST/Default Web Site")
authoringSection.Properties.Item("enabled").Value = True
authoringSection.Properties.Item("requireSsl").Value = False

adminManager.CommitChanges()