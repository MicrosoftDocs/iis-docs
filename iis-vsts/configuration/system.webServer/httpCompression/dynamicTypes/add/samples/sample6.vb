Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set httpCompressionSection = adminManager.GetAdminSection("system.webServer/httpCompression", "MACHINE/WEBROOT/APPHOST")
Set dynamicTypesCollection = httpCompressionSection.ChildElements.Item("dynamicTypes").Collection

Set addElement = dynamicTypesCollection.CreateNewElement("add")
addElement.Properties.Item("mimeType").Value = "application/msword"
addElement.Properties.Item("enabled").Value = True
dynamicTypesCollection.AddElement(addElement)

Set addElement1 = dynamicTypesCollection.CreateNewElement("add")
addElement1.Properties.Item("mimeType").Value = "application/vnd.ms-powerpoint"
addElement1.Properties.Item("enabled").Value = True
dynamicTypesCollection.AddElement(addElement1)

Set addElement2 = dynamicTypesCollection.CreateNewElement("add")
addElement2.Properties.Item("mimeType").Value = "application/vnd.ms-excel"
addElement2.Properties.Item("enabled").Value = True
dynamicTypesCollection.AddElement(addElement2)

adminManager.CommitChanges()