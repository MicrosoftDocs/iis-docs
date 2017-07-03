Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set serverRuntimeSection = adminManager.GetAdminSection("system.ftpServer/serverRuntime", "MACHINE/WEBROOT/APPHOST")
Set hostNameSupportElement = serverRuntimeSection.ChildElements.Item("hostNameSupport")
hostNameSupportElement.Properties.Item("useDomainNameAsHostName").Value = True

adminManager.CommitChanges()