Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set applicationDependenciesSection = adminManager.GetAdminSection("system.webServer/security/applicationDependencies", "MACHINE/WEBROOT/APPHOST/Default Web Site")

Set applicationDependenciesCollection = applicationDependenciesSection.Collection
Set applicationElement = applicationDependenciesCollection.CreateNewElement("application")
applicationElement.Properties.Item("name").Value = "My Custom Application"
applicationElement.Properties.Item("groupId").Value = "MyCustomGroup"

Set applicationCollection = applicationElement.Collection
Set addElement = applicationCollection.CreateNewElement("add")
addElement.Properties.Item("groupId").Value = "ASP"
applicationCollection.AddElement(addElement)
applicationDependenciesCollection.AddElement(applicationElement)

adminManager.CommitChanges()