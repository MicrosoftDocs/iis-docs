Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set httpCompressionSection = adminManager.GetAdminSection("system.webServer/httpCompression", "MACHINE/WEBROOT/APPHOST")
Set staticTypesCollection = httpCompressionSection.ChildElements.Item("staticTypes").Collection

Set addElement = staticTypesCollection.CreateNewElement("add")
addElement.Properties.Item("mimeType").Value = "application/msword"
addElement.Properties.Item("enabled").Value = True
staticTypesCollection.AddElement(addElement)

Set addElement1 = staticTypesCollection.CreateNewElement("add")
addElement1.Properties.Item("mimeType").Value = "application/vnd.ms-powerpoint"
addElement1.Properties.Item("enabled").Value = True
staticTypesCollection.AddElement(addElement1)

Set addElement2 = staticTypesCollection.CreateNewElement("add")
addElement2.Properties.Item("mimeType").Value = "application/vnd.ms-excel"
addElement2.Properties.Item("enabled").Value = True
staticTypesCollection.AddElement(addElement2)

adminManager.CommitChanges()