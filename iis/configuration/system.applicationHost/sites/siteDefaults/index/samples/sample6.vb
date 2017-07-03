Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST")
Set siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults")

Set limitsElement = siteDefaultsElement.ChildElements.Item("limits")
limitsElement.Properties.Item("connectionTimeout").Value = "00:02:00"

Set logFileElement = siteDefaultsElement.ChildElements.Item("logFile")
logFileElement.Properties.Item("logFormat").Value = "W3C"
logFileElement.Properties.Item("directory").Value = "%SystemDrive%\inetpub\logs\LogFiles"
logFileElement.Properties.Item("enabled").Value = True

Set traceFailedRequestsLoggingElement = siteDefaultsElement.ChildElements.Item("traceFailedRequestsLogging")
traceFailedRequestsLoggingElement.Properties.Item("enabled").Value = True
traceFailedRequestsLoggingElement.Properties.Item("directory").Value = "%SystemDrive%\inetpub\logs\FailedReqLogFiles"
traceFailedRequestsLoggingElement.Properties.Item("maxLogFiles").Value = 20

Set bindingsCollection = siteDefaultsElement.ChildElements.Item("bindings").Collection
Set bindingElement = bindingsCollection.CreateNewElement("binding")
bindingElement.Properties.Item("protocol").Value = "http"
bindingElement.Properties.Item("bindingInformation").Value = "127.0.0.1:8080:"
bindingsCollection.AddElement(bindingElement)

Set ftpServerElement = siteDefaultsElement.ChildElements.Item("ftpServer")
ftpServerElement.Properties.Item("serverAutoStart").Value = True

adminManager.CommitChanges()