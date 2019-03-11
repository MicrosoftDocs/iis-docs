Set adminManager = CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST")
Set siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults")
Set ftpServerElement = siteDefaultsElement.ChildElements.Item("ftpServer")
Set securityElement = ftpServerElement.ChildElements.Item("security")
Set customAuthorizationElement = securityElement.ChildElements.Item("customAuthorization")
Set providerElement = customAuthorizationElement.ChildElements.Item("provider")
providerElement.Properties.Item("name").Value = "MyCustomProvider"
providerElement.Properties.Item("enabled").Value = true

adminManager.CommitChanges()