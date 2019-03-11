Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site"
Set requestFilteringSection = adminManager.GetAdminSection("system.webServer/security/requestFiltering", "MACHINE/WEBROOT/APPHOST/Default Web Site")
Set hiddenSegmentsElement = requestFilteringSection.ChildElements.Item("hiddenSegments")
hiddenSegmentsElement.Properties.Item("applyToWebDAV").Value = False

Set hiddenSegmentsCollection = hiddenSegmentsElement.Collection

Set addElement = hiddenSegmentsCollection.CreateNewElement("add")
addElement.Properties.Item("segment").Value = "_private"
hiddenSegmentsCollection.AddElement(addElement)

adminManager.CommitChanges()