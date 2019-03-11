Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Contoso"
Set modulesSection = adminManager.GetAdminSection("system.webServer/modules", "MACHINE/WEBROOT/APPHOST/Contoso")
Set modulesCollection = modulesSection.Collection

Set addElement = modulesCollection.CreateNewElement("add")
addElement.Properties.Item("name").Value = "CartHeader"
addElement.Properties.Item("type").Value = "Contoso.ShoppingCart.Header"
addElement.Properties.Item("preCondition").Value = "managedHandler"
modulesCollection.AddElement addElement

adminManager.CommitChanges()