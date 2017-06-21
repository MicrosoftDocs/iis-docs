Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST")
Set siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults")
Set ftpServerElement = siteDefaultsElement.ChildElements.Item("ftpServer")

Set logFileElement = ftpServerElement.ChildElements.Item("logFile")
   logFileElement.Properties.Item("period").Value = "Daily"
   logFileElement.Properties.Item("enabled").Value = True

adminManager.CommitChanges()