Set adminManager = CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST")
Set siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults")
Set logFileElement = siteDefaultsElement.ChildElements.Item("logFile")
Set customFieldsElement = logFileElement.ChildElements.Item("customFields")

Set customFieldsCollection = customFieldsElement.Collection

Set addElement = customFieldsCollection.CreateNewElement("add")
addElement.Properties.Item("logFieldName").Value = "ContosoField"
addElement.Properties.Item("sourceName").Value = "ContosoSource"
addElement.Properties.Item("sourceType").Value = "ServerVariable"
customFieldsCollection.AddElement(addElement)

adminManager.CommitChanges()