Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set requestFilteringSection = adminManager.GetAdminSection("system.ftpServer/security/requestFiltering", "MACHINE/WEBROOT/APPHOST/Default Web Site")
Set requestLimitsElement = requestFilteringSection.ChildElements.Item("requestLimits")
requestLimitsElement.Properties.Item("maxAllowedContentLength").Value = 1000000
requestLimitsElement.Properties.Item("maxUrl").Value = 1024

adminManager.CommitChanges()