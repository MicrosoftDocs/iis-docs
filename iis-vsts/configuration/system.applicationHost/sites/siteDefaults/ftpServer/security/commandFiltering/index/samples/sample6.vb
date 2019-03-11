Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST")
Set siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults")
Set ftpServerElement = siteDefaultsElement.ChildElements.Item("ftpServer")

Set securityElement = ftpServerElement.ChildElements.Item("security")
Set commandFilteringElement = securityElement.ChildElements.Item("commandFiltering")
Set commandFilteringCollection = commandFilteringElement.Collection
Set addElement = commandFilteringCollection.CreateNewElement("add")
   addElement.Properties.Item("command").Value = "SYST"
   addElement.Properties.Item("allowed").Value = False
   commandFilteringCollection.AddElement(addElement)

adminManager.CommitChanges()