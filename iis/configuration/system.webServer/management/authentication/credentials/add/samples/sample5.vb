Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT"
adminManager.SetMetadata "pathMapper", "AdministrationConfig"

Set authenticationSection = adminManager.GetAdminSection("system.webServer/management/authentication", "MACHINE/WEBROOT")
Set credentialsCollection = authenticationSection.ChildElements.Item("credentials").Collection

Set addElement = credentialsCollection.CreateNewElement("add")
addElement.Properties.Item("name").Value = "ContosoUser"
addElement.Properties.Item("password").Value = "P@ssw0rd"
addElement.Properties.Item("enabled").Value = True
credentialsCollection.AddElement(addElement)

adminManager.CommitChanges()