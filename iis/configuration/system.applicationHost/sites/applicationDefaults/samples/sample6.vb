Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST")

Set applicationDefaultsElement = sitesSection.ChildElements.Item("applicationDefaults")
applicationDefaultsElement.Properties.Item("applicationPool").Value = "DefaultAppPool"

adminManager.CommitChanges()