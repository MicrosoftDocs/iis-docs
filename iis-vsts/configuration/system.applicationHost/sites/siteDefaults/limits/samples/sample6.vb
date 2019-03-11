Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST")
Set siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults")

Set limitsElement = siteDefaultsElement.ChildElements.Item("limits")
limitsElement.Properties.Item("connectionTimeout").Value = "00:03:00"

adminManager.CommitChanges()