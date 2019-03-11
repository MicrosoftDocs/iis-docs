Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site"
Set requestFilteringSection = adminManager.GetAdminSection("system.webServer/security/requestFiltering", "MACHINE/WEBROOT/APPHOST/Default Web Site")

Set alwaysAllowedQueryStringsCollection = requestFilteringSection.ChildElements.Item("alwaysAllowedQueryStrings").Collection
Set addElement = alwaysAllowedQueryStringsCollection.CreateNewElement("add")
addElement.Properties.Item("queryString").Value = "allowed=sequence"
alwaysAllowedQueryStringsCollection.AddElement(addElement)

adminManager.CommitChanges()