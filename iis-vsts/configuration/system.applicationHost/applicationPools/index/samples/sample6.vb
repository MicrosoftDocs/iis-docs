Set adminManager = CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set applicationPoolsSection = adminManager.GetAdminSection("system.applicationHost/applicationPools","MACHINE/WEBROOT/APPHOST")
Set applicationPoolsCollection = applicationPoolsSection.Collection

Set addElement = applicationPoolsCollection.CreateNewElement("add")
addElement.Properties.Item("name").Value = "Contoso"
addElement.Properties.Item("autoStart").Value = True
addElement.Properties.Item("managedPipelineMode").Value = "Integrated"
applicationPoolsCollection.AddElement(addElement)

adminManager.CommitChanges()