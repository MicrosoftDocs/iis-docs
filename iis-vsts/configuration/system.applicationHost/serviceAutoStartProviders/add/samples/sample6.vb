Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set serviceAutoStartProvidersSection = adminManager.GetAdminSection("system.applicationHost/serviceAutoStartProviders", "MACHINE/WEBROOT/APPHOST")
Set serviceAutoStartProvidersCollection = serviceAutoStartProvidersSection.Collection

Set addElement = serviceAutoStartProvidersCollection.CreateNewElement("add")
addElement.Properties.Item("name").Value = "MyAutostartProvider"
addElement.Properties.Item("type").Value = "MyAutostartProvider, MyAutostartProvider, version=1.0.0.0, Culture=neutral, PublicKeyToken=426f62526f636b73"
serviceAutoStartProvidersCollection.AddElement(addElement)

adminManager.CommitChanges()