Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set cachingSection = adminManager.GetAdminSection("system.webServer/caching", "MACHINE/WEBROOT/APPHOST")
Set profilesCollection = cachingSection.ChildElements.Item("profiles").Collection

Set addElement = profilesCollection.CreateNewElement("add")
addElement.Properties.Item("extension").Value = "asp"
addElement.Properties.Item("policy").Value = "CacheUntilChange"
addElement.Properties.Item("kernelCachePolicy").Value = "CacheUntilChange"
profilesCollection.AddElement addElement, 0

adminManager.CommitChanges()