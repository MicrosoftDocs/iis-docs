Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set httpLoggingSection = adminManager.GetAdminSection("system.webServer/httpLogging", "MACHINE/WEBROOT/APPHOST/Contoso")
httpLoggingSection.Properties.Item("selectiveLogging").Value = "LogAll"
httpLoggingSection.Properties.Item("dontLog").Value = True

adminManager.CommitChanges()