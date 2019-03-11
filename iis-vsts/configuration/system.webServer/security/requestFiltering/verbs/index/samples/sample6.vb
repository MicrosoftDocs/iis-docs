Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site"
Set requestFilteringSection = adminManager.GetAdminSection("system.webServer/security/requestFiltering", "MACHINE/WEBROOT/APPHOST/Default Web Site")

Set verbsElement = requestFilteringSection.ChildElements.Item("verbs")
verbsElement.Properties.Item("applyToWebDAV").Value = False
Set verbsCollection = verbsElement.Collection

Set addElement = verbsCollection.CreateNewElement("add")
addElement.Properties.Item("verb").Value = "PUT"
addElement.Properties.Item("allowed").Value = False
verbsCollection.AddElement(addElement)

adminManager.CommitChanges()