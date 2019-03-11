Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set logSection = adminManager.GetAdminSection("system.ftpServer/log", "MACHINE/WEBROOT/APPHOST")
logSection.Properties.Item("centralLogFileMode").Value = "Central"

Set centralLogFileElement = logSection.ChildElements.Item("centralLogFile")
centralLogFileElement.Properties.Item("enabled").Value = True

adminManager.CommitChanges()