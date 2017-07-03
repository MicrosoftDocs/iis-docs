Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site"
Set httpProtocolSection = adminManager.GetAdminSection("system.webServer/httpProtocol", "MACHINE/WEBROOT/APPHOST/Default Web Site")
Set customHeadersCollection = httpProtocolSection.ChildElements.Item("customHeaders").Collection

Set addElement = customHeadersCollection.CreateNewElement("add")
addElement.Properties.Item("name").Value = "X-Custom-Name"
addElement.Properties.Item("value").Value = "MyCustomValue"
customHeadersCollection.AddElement(addElement)

adminManager.CommitChanges()