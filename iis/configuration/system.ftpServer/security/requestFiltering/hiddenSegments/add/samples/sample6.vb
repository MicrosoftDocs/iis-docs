Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set requestFilteringSection = adminManager.GetAdminSection("system.ftpServer/security/requestFiltering", "MACHINE/WEBROOT/APPHOST/Default Web Site")
Set hiddenSegmentsCollection = requestFilteringSection.ChildElements.Item("hiddenSegments").Collection

Set addElement = hiddenSegmentsCollection.CreateNewElement("add")
addElement.Properties.Item("segment").Value = "bin"
hiddenSegmentsCollection.AddElement(addElement)

Set addElement1 = hiddenSegmentsCollection.CreateNewElement("add")
addElement1.Properties.Item("segment").Value = "App_Code"
hiddenSegmentsCollection.AddElement(addElement1)

adminManager.CommitChanges()