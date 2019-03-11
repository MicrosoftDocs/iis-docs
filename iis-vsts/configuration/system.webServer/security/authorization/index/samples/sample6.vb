Set adminManager = CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Contoso"
Set authorizationSection = adminManager.GetAdminSection("system.webServer/security/authorization", "MACHINE/WEBROOT/APPHOST/Contoso")
Set authorizationCollection = authorizationSection.Collection

Set addElement = authorizationCollection.CreateNewElement("add")
addElement.Properties.Item("accessType").Value = "Allow"
addElement.Properties.Item("roles").Value = "administrators"
authorizationCollection.AddElement(addElement)

adminManager.CommitChanges()