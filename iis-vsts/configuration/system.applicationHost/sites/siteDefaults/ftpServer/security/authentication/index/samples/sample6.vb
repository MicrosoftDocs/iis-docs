Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST")
Set siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults")
Set ftpServerElement = siteDefaultsElement.ChildElements.Item("ftpServer")

Set securityElement = ftpServerElement.ChildElements.Item("security")
Set authenticationElement = securityElement.ChildElements.Item("authentication")
Set anonymousAuthenticationElement = authenticationElement.ChildElements.Item("anonymousAuthentication")
   anonymousAuthenticationElement.Properties.Item("enabled").Value = False
Set basicAuthenticationElement = authenticationElement.ChildElements.Item("basicAuthentication")
   basicAuthenticationElement.Properties.Item("enabled").Value = true

adminManager.CommitChanges()