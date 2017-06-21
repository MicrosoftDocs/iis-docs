Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST")
Set virtualDirectoryDefaultsElement = sitesSection.ChildElements.Item("virtualDirectoryDefaults")
virtualDirectoryDefaultsElement.Properties.Item("logonMethod").Value = "Network"

adminManager.CommitChanges()