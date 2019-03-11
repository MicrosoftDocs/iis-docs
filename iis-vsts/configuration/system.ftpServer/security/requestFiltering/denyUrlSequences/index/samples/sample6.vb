Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set requestFilteringSection = adminManager.GetAdminSection("system.ftpServer/security/requestFiltering", "MACHINE/WEBROOT/APPHOST/Default Web Site")
Set denyUrlSequencesCollection = requestFilteringSection.ChildElements.Item("denyUrlSequences").Collection

Set addElement = denyUrlSequencesCollection.CreateNewElement("add")
addElement.Properties.Item("sequence").Value = "bin"
denyUrlSequencesCollection.AddElement(addElement)

adminManager.CommitChanges()