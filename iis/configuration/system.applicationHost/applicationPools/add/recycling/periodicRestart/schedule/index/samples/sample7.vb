Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set applicationPoolsSection = adminManager.GetAdminSection("system.applicationHost/applicationPools", "MACHINE/WEBROOT/APPHOST")
Set applicationPoolsCollection = applicationPoolsSection.Collection

Set addElement = applicationPoolsCollection.CreateNewElement("add")
addElement.Properties.Item("name").Value = "Contoso"
Set recyclingElement = addElement.ChildElements.Item("recycling")
Set periodicRestartElement = recyclingElement.ChildElements.Item("periodicRestart")
Set scheduleCollection = periodicRestartElement.ChildElements.Item("schedule").Collection
Set addElement1 = scheduleCollection.CreateNewElement("add")
addElement1.Properties.Item("value").Value = "03:00:00"
scheduleCollection.AddElement(addElement1)
applicationPoolsCollection.AddElement(addElement)

adminManager.CommitChanges()