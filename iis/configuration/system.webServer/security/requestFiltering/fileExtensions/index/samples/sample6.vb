Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site"
Set requestFilteringSection = adminManager.GetAdminSection("system.webServer/security/requestFiltering", "MACHINE/WEBROOT/APPHOST/Default Web Site")

Set fileExtensionsElement = requestFilteringSection.ChildElements.Item("fileExtensions")
fileExtensionsElement.Properties.Item("applyToWebDAV").Value = False
Set fileExtensionsCollection = fileExtensionsElement.Collection

Set addElement = fileExtensionsCollection.CreateNewElement("add")
addElement.Properties.Item("fileExtension").Value = "inc"
addElement.Properties.Item("allowed").Value = False
fileExtensionsCollection.AddElement(addElement)

adminManager.CommitChanges()