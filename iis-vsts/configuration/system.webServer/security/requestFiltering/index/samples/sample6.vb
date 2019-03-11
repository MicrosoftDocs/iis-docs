Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site"
Set requestFilteringSection = adminManager.GetAdminSection("system.webServer/security/requestFiltering", "MACHINE/WEBROOT/APPHOST/Default Web Site")
Set denyUrlSequencesCollection = requestFilteringSection.ChildElements.Item("denyUrlSequences").Collection

Set addElement = denyUrlSequencesCollection.CreateNewElement("add")
addElement.Properties.Item("sequence").Value = ".."
denyUrlSequencesCollection.AddElement(addElement)

Set addElement1 = denyUrlSequencesCollection.CreateNewElement("add")
addElement1.Properties.Item("sequence").Value = ":"
denyUrlSequencesCollection.AddElement(addElement1)

Set addElement2 = denyUrlSequencesCollection.CreateNewElement("add")
addElement2.Properties.Item("sequence").Value = "\"
denyUrlSequencesCollection.AddElement(addElement2)

adminManager.CommitChanges()