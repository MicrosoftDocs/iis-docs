Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST")
Set siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults")

Set logFileElement = siteDefaultsElement.ChildElements.Item("logFile")
logFileElement.Properties.Item("logFormat").Value = "W3C"
logFileElement.Properties.Item("directory").Value = "%SystemDrive%\inetpub\logs\LogFiles"
logFileElement.Properties.Item("enabled").Value = True

adminManager.CommitChanges()