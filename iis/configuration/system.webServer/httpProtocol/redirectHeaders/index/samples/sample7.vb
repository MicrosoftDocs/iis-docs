Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site"
Set httpProtocolSection = adminManager.GetAdminSection("system.webServer/httpProtocol", "MACHINE/WEBROOT/APPHOST/Default Web Site")
Set redirectHeadersCollection = httpProtocolSection.ChildElements.Item("redirectHeaders").Collection

Set addElement = redirectHeadersCollection.CreateNewElement("add")
addElement.Properties.Item("name").Value = "X-Custom-Redirect-Header"
addElement.Properties.Item("value").Value = "MyRedirectValue"
redirectHeadersCollection.AddElement(addElement)

adminManager.CommitChanges()