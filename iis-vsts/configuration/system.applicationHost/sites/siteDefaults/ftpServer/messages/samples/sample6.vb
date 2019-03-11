Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST")
Set siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults")
Set ftpServerElement = siteDefaultsElement.ChildElements.Item("ftpServer")

Set messagesElement = ftpServerElement.ChildElements.Item("messages")
   messagesElement.Properties.Item("bannerMessage").Value = "Welcome!"
   messagesElement.Properties.Item("allowLocalDetailedErrors").Value = True

adminManager.CommitChanges()