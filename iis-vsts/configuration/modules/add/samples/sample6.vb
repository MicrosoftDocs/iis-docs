Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT"
adminManager.SetMetadata "pathMapper", "AdministrationConfig"
Set modulesSection = adminManager.GetAdminSection("modules", "MACHINE/WEBROOT")

Set modulesCollection = modulesSection.Collection
Set addElement = modulesCollection.CreateNewElement("add")
addElement.Properties.Item("name").Value = "ContosoProvider"
modulesCollection.AddElement(addElement)

adminManager.CommitChanges()