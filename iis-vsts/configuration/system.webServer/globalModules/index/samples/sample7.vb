Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set globalModulesSection = adminManager.GetAdminSection("system.webServer/globalModules", "MACHINE/WEBROOT/APPHOST")
Set globalModulesCollection = globalModulesSection.Collection

Set addElement = globalModulesCollection.CreateNewElement("add")
addElement.Properties.Item("name").Value = "ImageCopyrightModule"
addElement.Properties.Item("image").Value = "%windir%\system32\inetsrv\imageCopyrightModule.dll"
globalModulesCollection.AddElement addElement

adminManager.CommitChanges()