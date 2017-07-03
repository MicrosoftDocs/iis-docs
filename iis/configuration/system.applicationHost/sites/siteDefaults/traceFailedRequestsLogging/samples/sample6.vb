Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST")
Set siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults")

Set traceFailedRequestsLoggingElement = siteDefaultsElement.ChildElements.Item("traceFailedRequestsLogging")
traceFailedRequestsLoggingElement.Properties.Item("enabled").Value = True
traceFailedRequestsLoggingElement.Properties.Item("directory").Value = "%SystemDrive%\inetpub\logs\FailedReqLogFiles"
traceFailedRequestsLoggingElement.Properties.Item("maxLogFiles").Value = 20

adminManager.CommitChanges()