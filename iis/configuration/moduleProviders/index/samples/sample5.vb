Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT"
adminManager.SetMetadata "pathMapper", "AdministrationConfig"
Set modulesSection = adminManager.GetAdminSection("modules", "MACHINE/WEBROOT")

Set moduleProvidersCollection = modulesSection.Collection
Set addElement = moduleProvidersCollection.CreateNewElement("add")
addElement.Properties.Item("name").Value = "ContosoProvider"
addElement.Properties.Item("type").Value = "Contoso.Provider, System.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=426f62526f636b73"
moduleProvidersCollection.AddElement(addElement)

adminManager.CommitChanges()
