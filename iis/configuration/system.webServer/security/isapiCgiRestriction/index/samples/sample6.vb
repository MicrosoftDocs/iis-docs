Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set isapiCgiRestrictionSection = adminManager.GetAdminSection("system.webServer/security/isapiCgiRestriction", "MACHINE/WEBROOT/APPHOST")
Set isapiCgiRestrictionCollection = isapiCgiRestrictionSection.Collection

Set addElement = isapiCgiRestrictionCollection.CreateNewElement("add")
addElement.Properties.Item("path").Value = "C:\Inetpub\www.contoso.com\wwwroot\isapi\custom.dll"
addElement.Properties.Item("allowed").Value = True
addElement.Properties.Item("groupId").Value = "ContosoGroup"
addElement.Properties.Item("description").Value = "Contoso Extension"
isapiCgiRestrictionCollection.AddElement(addElement)

adminManager.CommitChanges()