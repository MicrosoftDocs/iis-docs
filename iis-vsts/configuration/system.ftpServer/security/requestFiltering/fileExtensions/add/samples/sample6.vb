Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set requestFilteringSection = adminManager.GetAdminSection("system.ftpServer/security/requestFiltering", "MACHINE/WEBROOT/APPHOST/Default Web Site")
Set fileExtensionsElement = requestFilteringSection.ChildElements.Item("fileExtensions")
Set fileExtensionsCollection = fileExtensionsElement.Collection

Set addElement = fileExtensionsCollection.CreateNewElement("add")
addElement.Properties.Item("fileExtension").Value = ".exe"
addElement.Properties.Item("allowed").Value = False
fileExtensionsCollection.AddElement(addElement)

Set addElement1 = fileExtensionsCollection.CreateNewElement("add")
addElement1.Properties.Item("fileExtension").Value = ".com"
addElement1.Properties.Item("allowed").Value = False
fileExtensionsCollection.AddElement(addElement1)

Set addElement2 = fileExtensionsCollection.CreateNewElement("add")
addElement2.Properties.Item("fileExtension").Value = ".cmd"
addElement2.Properties.Item("allowed").Value = False
fileExtensionsCollection.AddElement(addElement2)

Set addElement3 = fileExtensionsCollection.CreateNewElement("add")
addElement3.Properties.Item("fileExtension").Value = ".bat"
addElement3.Properties.Item("allowed").Value = False
fileExtensionsCollection.AddElement(addElement3)

adminManager.CommitChanges()