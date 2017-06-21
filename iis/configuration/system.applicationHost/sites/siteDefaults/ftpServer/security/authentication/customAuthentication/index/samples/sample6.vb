Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST")
Set siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults")
Set ftpServerElement = siteDefaultsElement.ChildElements.Item("ftpServer")

Set securityElement = ftpServerElement.ChildElements.Item("security")
Set authenticationElement = securityElement.ChildElements.Item("authentication")
Set customAuthenticationElement = authenticationElement.ChildElements.Item("customAuthentication")
Set providersCollection = customAuthenticationElement.ChildElements.Item("providers").Collection
Set addElement1 = providersCollection.CreateNewElement("add")
   addElement1.Properties.Item("name").Value = "FtpCustomAuthenticationModule"
   addElement1.Properties.Item("enabled").Value = True
   providersCollection.AddElement(addElement1)

adminManager.CommitChanges()