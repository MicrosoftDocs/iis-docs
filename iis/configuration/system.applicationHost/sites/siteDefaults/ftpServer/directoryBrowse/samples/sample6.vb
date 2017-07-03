Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST")
Set siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults")
Set ftpServerElement = siteDefaultsElement.ChildElements.Item("ftpServer")

Set directoryBrowseElement = ftpServerElement.ChildElements.Item("directoryBrowse")
   directoryBrowseElement.Properties.Item("showFlags").Value = "StyleUnix, DisplayAvailableBytes"

adminManager.CommitChanges()