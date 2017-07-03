Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Contoso"

Set defaultDocumentSection = adminManager.GetAdminSection("system.webServer/defaultDocument", _
   "MACHINE/WEBROOT/APPHOST/Contoso")

defaultDocumentSection.Properties.Item("enabled").Value = True  

Set filesCollection = defaultDocumentSection.ChildElements.Item("files").Collection

Set addElement = filesCollection.CreateNewElement("add")
addElement.Properties.Item("value").Value = "home.html"
filesCollection.AddElement addElement, 0

adminManager.CommitChanges